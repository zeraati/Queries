using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Queries
{
    public partial class frmMain : Form
    {
        Functions Functions = new Functions();

        // table name of table query
        DataTable dtTbNmQrTb = new DataTable();

        string query;
        string strPathLoginFolder = @"Login.pos";
        string strPathQueriesFolder = @"Queries\";
        string strPathRoidadFolder = @"Roidad\";

        SqlConnection sqlConnect = new SqlConnection();


        public frmMain()
        {
            InitializeComponent();

            //defult disable
            this.cmbDBNames.Enabled = this.grbQry.Enabled = false;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            cmbServer.DataSource = ServerName(strPathLoginFolder);

            //*********** defult!!!!!!            
            cmbServer.Text = @"172.20.18.53";
            btnConnect_Click(null, null);
            cmbDBNames.Text = "_Main";
            cmbQryTyp_SelectedIndexChanged(null, null);

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            // get server info ==> server , user , pass
            string strServer = cmbServer.Text, strUser = txtUser.Text, strPass = txtPass.Text;


            //  create sql connection
            sqlConnect = Functions.SqlConnect(strServer, strUser, strPass);


            //  test sql connection
            if (Functions.SqlConnectionTest(sqlConnect))
            {

                #region save login info with encrypt pass

                //  save login info with encrypt pass
                if (chbRemember.CheckState == CheckState.Checked)
                {
                    //  encrypt pass
                    string strPassEncrypt = CryptorEngine.Encrypt(strPass, true);

                    List<string> lst = Functions.ReadTxt(strPathLoginFolder);


                    //  save login when login file info is empty
                    if (File.ReadAllText(strPathLoginFolder) == "")
                    { File.WriteAllText(strPathLoginFolder, strServer + "," + strUser + "," + strPassEncrypt); }


                    //  save or replace login when login file info is not empty
                    if (File.ReadAllText(strPathLoginFolder) != "")
                    {
                        int intFind = Functions.ListFind(lst, strServer);

                        if (intFind != -1)
                        {
                            lst[intFind] = strServer + "," + strUser + "," + strPassEncrypt;
                            Functions.saveList(lst, strPathLoginFolder);
                        }

                        else File.WriteAllText(strPathLoginFolder, File.ReadAllText(strPathLoginFolder) + "\r\n" + strServer + "," + strUser + "," + strPassEncrypt);
                    }

                    //  load server name
                    cmbServer.DataSource = ServerName(strPathLoginFolder);
                }

                #endregion


                //  load database name  // set source cmbDBNames 
                Functions.ComboBoxSource(cmbDBNames, Functions.SqlGetDBName(sqlConnect));


                //  load query names
                LoadQueryFileName();


                //  enable group box Query
                this.cmbDBNames.Enabled = this.grbQry.Enabled = true;


                // set btnConnect text
                btnConnect.Text = "اتصال مجدد";

                //  read roidad
                LoadRoidad(cmbRoidad);

            }

            else   //   if problem in sql connection
            {
                MessageBox.Show("عدم برقراری ارتباط", "!هشدار");
                btnConnect.Text = "اتصال";
            }

            if (cmbDBNames.Items.Count != 0) cmbDBNames.DropDownWidth = DropDownWidth(cmbDBNames);
        }

        private void cmbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  server
            string strServer = cmbServer.Text;

            // server info ==> server , user , pass
            List<string> lstServerInfo = new List<string>();


            //  get server info
            lstServerInfo = serverUserPass(strPathLoginFolder, strServer);
            txtUser.Text = lstServerInfo[1];
            txtPass.Text = lstServerInfo[2];


        }

        private void cmbDBNames_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  set cmbTBName source
            if (cmbDBNames.Text != "System.Data.DataRowView")
            {

                //  sql connection change database
                sqlConnect = Functions.SqlConnectionChangeDB(sqlConnect, cmbDBNames.Text);

                //  set cmbTBName soutce    // load table names
                cmbTBName.DataSource = Functions.SqlTableName(sqlConnect);
            }

            if (cmbTBName.Items.Count != 0) cmbTBName.DropDownWidth = DropDownWidth(cmbTBName);
        }

        private void tsmiQry_Click(object sender, EventArgs e)
        {
            frmQueries frmQuery = new frmQueries();
            frmQuery.ShowDialog();
            cmbQryTyp_SelectedIndexChanged(null, null);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //  wait cursor
            this.Enabled = false; Cursor.Current = Cursors.WaitCursor;

            // load roidad names
            LoadRoidad(cmbRoidad);


            string strQuery = "";
            //  list report final query
            List<string> lstRpt = new List<string>();
            List<string> lstQuery = new List<string>();
            List<string> lstSqlError = new List<string>();


            if (cmbQryTyp.Text == "ستون")
            {
                lstRpt = RunQry(GetAllSelectedQuery(cmbFrstQry.Text, chlbxQueryFileName), cmbTBName.Text, out lstQuery, out lstSqlError);

                //  remove columns at end
                Functions.SqlExcutCommand(sqlConnect, "ALTER TABLE [" + cmbTBName.Text + "] DROP COLUMN  MKID,TeacherID,CodePaziresh");
            }

            if (cmbQryTyp.Text == "جدول")
            { lstRpt = RunQry(GetAllSelectedQuery(cmbFrstQry.Text, chlbxQueryFileName), out lstQuery, out lstSqlError); }



            //  show text query
            for (int i = 0; i < lstQuery.Count; i++)
            { strQuery = strQuery + lstQuery[i] + "\r\n"; }

            txtQuery.Text = strQuery;

            // sql error
            dgvResult.DataSource = lstSqlError;

            //  show report to lstreport
            lstReport.DataSource = lstRpt;


            //wait default
            this.Enabled = true; Cursor.Current = Cursors.Default;
        }

        private void cmbRoidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  unchecked all items
            ClsAllCheck(chlbxQueryFileName, false);

            //  checked from list
            if (cmbRoidad.SelectedIndex != 0)
            {
                List<string> lst = new List<string>();
                var fileStream = new FileStream(strPathRoidadFolder + cmbRoidad.Text + ".txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    { lst.Add(line); }
                }

                listCheckedItem(lst);
            }
        }

        private void cmbFrstQry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  set chlbFild source  // load query field name
            LoadQueryFileName();


            chlbxQueryFileName.Items.Remove(cmbFrstQry.Text);

            if (cmbFrstQry.Text != "System.Data.DataRowView")
            { cmbTBName.Text = Functions.QueryGetTableName(File.ReadAllText(strPathQueriesFolder + cmbFrstQry.Text + ".sql")); }

            cmbFrstQry.DropDownWidth = DropDownWidth(cmbFrstQry);
        }

        private void btnDelRdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(" حذف شود [" + cmbRoidad.Text + "] آیا رویداد ", "!هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.Yes)
            {
                File.Delete(strPathRoidadFolder + cmbRoidad.Text + ".txt");
                LoadRoidad(cmbRoidad);
                cmbRoidad.SelectedIndex = 0;
            }
        }

        private void cmbQryTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  hide element for table
            if (cmbQryTyp.Text == "جدول")
            { cmbFrstQry.Visible = lblFirstQuery.Visible = btnSave.Visible = cmbRoidad.Visible = lblRoidad.Visible = btnDelRdd.Visible = txtTop.Visible = cmbTBName.Visible = lblTBName.Visible = false; }


            //  show element for column
            if (cmbQryTyp.Text == "ستون")
            { lblFirstQuery.Visible = cmbFrstQry.Visible = btnSave.Visible = cmbRoidad.Visible = lblRoidad.Visible = btnDelRdd.Visible = txtTop.Visible = cmbTBName.Visible = lblTBName.Visible = true; }


            //  LoadQueryFileName
            LoadQueryFileName();
        }


        //  LoadQueryFileName
        private void txtFilterQueryFileName_TextChanged(object sender, EventArgs e)
        {
            LoadQueryFileName2();


        }


        private void cmbTBName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// save roidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // all checked in list
            List<string> lst = GetAllSelectedQuery(cmbFrstQry.Text, chlbxQueryFileName);

            //  save to text file

            if (cmbRoidad.Text != "")
            {
                Functions.saveList(lst, strPathRoidadFolder + cmbRoidad.Text + ".txt");
                LoadRoidad(cmbRoidad);
            }
            else MessageBox.Show("نام رویداد را وارد کنید!", "!هشدار");
        }


        //*****************         functions

        #region lstSvrName
        /// <summary>
        /// get server name from file
        /// </summary>
        /// <param name="strPathLogin">login file path</param>
        /// <returns>List</returns>
        private List<string> ServerName(string strPathLogin)
        {
            List<string> lstSvrName = new List<string>();

            //  load server names into cmbServer
            if (File.Exists(strPathLogin))
            {
                lstSvrName = Functions.ReadTxt(strPathLogin);

                lstSvrName.Insert(0, "., ,");

                //  get server from read line
                for (int i = 0; i < lstSvrName.Count; i++)
                { lstSvrName[i] = lstSvrName[i].Substring(0, lstSvrName[i].IndexOf(",")); }

            }

            return lstSvrName;
        }
        #endregion



        #region serverUserPass
        /// <summary>
        /// serverUserPass
        /// </summary>
        /// <param name="loginPath">مسیر فایل اطلاعات ورود به سرور</param>
        /// <param name="server">سرور</param>
        /// <returns>لیست شامل نام سرور ، نام کاربری و رمز عبور سرور</returns>
        private List<string> serverUserPass(string loginPath, string server)
        {
            //  return list 
            List<string> lst = new List<string>();
            lst.Add(server); // add server



            //  all servers login info
            List<string> lstLogin = new List<string>();
            lstLogin = Functions.ReadTxt(loginPath);


            //  get this server user & pass add to lst
            for (int i = 0; i < lstLogin.Count; i++)
            {
                //  find this server info
                if (lstLogin[i].Contains(server))
                {
                    //  finde index of separator
                    List<int> lstIndexOf = new List<int>();
                    lstIndexOf = Functions.IndexOfAll(lstLogin[i], ",");

                    //  add user & pass to lst
                    lst.Add(lstLogin[i].Substring(lstIndexOf[0], (lstIndexOf[1] - lstIndexOf[0]) - 1));
                    lst.Add(lstLogin[i].Substring(lstIndexOf[1], lstLogin[i].Length - lstIndexOf[1]));
                }
            }


            //  set user & pass when server is local
            if (server == ".") lst[1] = lst[2] = "";

            //  decrypt pass
            try { lst[2] = CryptorEngine.Decrypt(lst[2], true); }
            catch (Exception) { }


            return lst;
        }

        #endregion


        #region roidad

        //  load roidad file
        public void LoadRoidad(ComboBox Roidad)
        {
            Roidad.Items.Clear();

            Roidad.Items.Add("هیچکدام");

            //  get all roidad files
            string[] Roidadfiles = Directory.GetFiles(strPathRoidadFolder, "*.txt");

            //  add roidad name in combobox
            foreach (string file in Roidadfiles)
            { Roidad.Items.Add(Path.GetFileNameWithoutExtension(file)); }
        }


        //  list of all query selected
        public List<string> GetAllSelectedQuery(string strFirstQry, CheckedListBox chlstbxQueries)
        {

            //  list checked
            List<string> lstChecked = new List<string>();

            lstChecked.Add(strFirstQry);

            for (int i = 0; i < chlstbxQueries.Items.Count; i++)
            {
                if (chlstbxQueries.GetItemCheckState(i) == CheckState.Checked)
                { lstChecked.Add(chlstbxQueries.Items[i].ToString()); }
            }

            return lstChecked;
        }


        #endregion



        private void ShowFinalTable()
        {
            if (txtTop.Text == "")
            { query = "Select * From dbo.[" + cmbTBName.Text + "]"; }

            else
            { query = "Select TOP " + txtTop.Text + " * From dbo.[" + cmbTBName.Text + "]"; }


            //  record table  set  source
            dgvResult.DataSource = Functions.SqlDataAdapter(sqlConnect, query);


            //  set cmbTBName soutce    // load table names
            cmbTBName.DataSource = Functions.SqlTableName(sqlConnect);


        }


        #region RunQry

        public List<string> RunQry(List<string> lstQrysNam, string strTbName, out List<string> lstQuery, out List<string> lstSqlError)
        {
            string strQuery;

            List<string> lstQueryText = new List<string>();
            List<string> lstSqlErrorIn = new List<string>();
            List<string> lstSqlErrorInGO = new List<string>();
            List<string> lstResultGO = new List<string>();
            List<string> lstResultAll = new List<string>();


            for (int i = 0; i < lstQrysNam.Count; i++)
            {
                string strSqlError = "";

                //  text query
                strQuery = File.ReadAllText(strPathQueriesFolder + lstQrysNam[i] + ".sql");

                //  change table query
                strQuery = Functions.SqlQueryChangeTableName(strQuery, strTbName);

                //  run query & result
                if (strQuery.Contains("GO"))
                { lstResultGO = Functions.SqlExcutCommandWithGO(sqlConnect, strQuery, out lstSqlErrorInGO, lstQrysNam[i]); }

                else
                    lstResultAll.Add(Functions.SqlExcutCommand(sqlConnect, strQuery, out strSqlError, lstQrysNam[i]));


                // out parameter text query
                lstQueryText.Add(strQuery);

                // out parameter sql error
                lstSqlErrorIn.Add(strSqlError);
                for (int j = 0; j < lstSqlErrorInGO.Count; j++)
                { lstSqlErrorIn.Add(lstSqlErrorInGO[j]); }
            }


            //  out list of text query
            lstQuery = lstQueryText;

            //  create full list report
            for (int i = 0; i < lstResultGO.Count; i++)
            { lstResultAll.Add(lstResultGO[i]); }

            //  out list of sql error
            lstSqlError = lstSqlErrorIn;

            //  return
            return lstResultAll;
        }

        public List<string> RunQry(List<string> lstQrysNam, out List<string> lstQuery, out List<string> lstSqlError)
        {
            string strQuery = "";
            List<string> lstQueryText = new List<string>();
            List<string> lstSqlErrorInGO = new List<string>();
            List<string> lstSqlErrorIn = new List<string>();
            List<string> lstResult = new List<string>();


            for (int i = 0; i < lstQrysNam.Count; i++)
            {
                string strSqlError = "";

                //  text query
                strQuery = File.ReadAllText(strPathQueriesFolder + lstQrysNam[i] + ".sql");

                //  run query & result
                if (strQuery.Contains("GO"))
                { lstResult = Functions.SqlExcutCommandWithGO(sqlConnect, strQuery, out lstSqlErrorInGO, lstQrysNam[i]); }

                else
                    lstResult.Add(Functions.SqlExcutCommand(sqlConnect, strQuery, out strSqlError, lstQrysNam[i]));

                // out parameter query
                lstQueryText.Add(strQuery);

                // out parameter sql error
                lstSqlErrorIn.Add(strSqlError);
                for (int j = 0; j < lstSqlErrorInGO.Count; j++)
                { lstSqlErrorIn.Add(lstSqlErrorInGO[j]); }
            }

            //  out list of text query
            lstQuery = lstQueryText;


            //  out list of sql error
            lstSqlError = lstSqlErrorIn;

            //  return
            return lstResult;
        }
        #endregion

        public void listCheckedItem(List<string> lst)
        {
            cmbFrstQry.Text = lst[0].ToString();

            for (int i = 1; i < lst.Count; i++)
            {
                for (int j = 0; j < chlbxQueryFileName.Items.Count; j++)
                {
                    string strItemText = lst[i].ToString();
                    string strSelecteItem = chlbxQueryFileName.Items[j].ToString();

                    if (strSelecteItem.Contains(strItemText.Substring(3, strItemText.Length-3))==true)
                    { chlbxQueryFileName.SetItemChecked(j, true); }
                }
            }
        }

        public void ClsAllCheck(CheckedListBox clb, bool set)
        {
            for (int k = 0; k < clb.Items.Count; k++)
            { clb.SetItemChecked(k, set); }
        }

        public string ReplaceText(string text, string OldText, string NewText)
        {
            string ret = text.Replace(OldText, NewText);

            return ret;
        }

        int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label lbl1 = new Label();

            foreach (var obj in myCombo.Items)
            {
                lbl1.Text = obj.ToString();
                temp = lbl1.PreferredWidth;
                if (temp > maxWidth)
                { maxWidth = temp; }
            }

            lbl1.Dispose();


            return maxWidth;
        }

        public string ReadQuery(string strPathQryFolder, string strQryName, string strTBName)
        {
            string strPathQry = strPathQryFolder + @"\" + strQryName + ".sql";
            string strState = "ReadQuery|" + Path.GetFileNameWithoutExtension(strPathQry);
            string strQry = "", strQryAll = "", strSqlError = "", strResault = "";
            string[] strQryAry;


            List<string> list = new List<string>();

            #region read text query

            //  read text query
            var fileStream = new FileStream(strPathQry, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    //  replace "GO" with "^" for split query
                    if (line.ToUpper() == "GO") { strQryAll += "^"; }

                    //  برای خوانایی کوئری
                    else strQryAll += "\r\n" + line;
                }
            }

            #endregion


            //  query text split
            strQryAry = strQryAll.Split('^');


            foreach (string item in strQryAry)
            {

                //  set table name in query
                strQry = ReplaceText(item, "TABLENAME", strTBName);

                //  run query & show resault
                strResault = Functions.SqlExcutCommand(sqlConnect, strQry, out strSqlError, "ReadQuery");
            }

            //  resault
            return strResault;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {if (txtQuery.Text != "") Clipboard.SetText(txtQuery.Text);}


        //  load query file name
        private void LoadQueryFileName()
        {
            //  list of query file name
            string strFilter = "";// txtFilterQueryFileName.Text;
            List<string> lstQueryFileName = Functions.DataTableToList(Functions.GetQueryFileName(strPathQueriesFolder, cmbQryTyp.Text, strFilter));

            //  set chlbFild source  // load field name
            Functions.CheckedListBoxSource(lstQueryFileName, chlbxQueryFileName);

            //  set combobox source
            cmbFrstQry.DataSource = Functions.DataTableToList(Functions.GetQueryFileName(strPathQueriesFolder, cmbQryTyp.Text));

        }


        private void LoadQueryFileName2()
        {

            //List<string> lst=Functions.GetSelectedItemsText


            //  list of query file name
            string strFilter = txtFilterQueryFileName.Text;
            List<string> lstQueryFileName = Functions.DataTableToList(Functions.GetQueryFileName(strPathQueriesFolder, cmbQryTyp.Text, strFilter));




            // clear list box
            chlbxQueryFileName.Items.Clear();

            // set list box source
            for (int i = 0; i < lstQueryFileName.Count; i++) chlbxQueryFileName.Items.Add(lstQueryFileName[i]);


        }


        //******************    End Function    ***************************
    }
}
