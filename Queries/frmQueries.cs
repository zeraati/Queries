using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Queries
{
    public partial class frmQueries : Form
    {

        string strPathQueries = @"Queries\";

        public frmQueries()
        {
            InitializeComponent();

            //load querys file name
            loadQueries();
        }


        // save query
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "")
            {
                // title number
                string strTitleNumber = txtTitleNum.Text.PadLeft(2, '0');

                // save query text
                File.WriteAllText(strPathQueries + strTitleNumber + "_" + txtTitle.Text + ".sql", txtQuery.Text, Encoding.UTF8);

                //load querys file name
                loadQueries();
            }

            else { MessageBox.Show("عنوان فایل را وارد کنید", "هشدار"); }

        }


        // del query
        private void btnDel_Click(object sender, EventArgs e)
        {
            // warrning del massage
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("آیا کوئری [" + lstbxQueriesNameColumn.Text + "] حذف شود ", "!هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            if (dr == DialogResult.Yes)
            {
                // del query file
                File.Delete(strPathQueries + lstbxQueriesNameColumn.Text + ".sql");

                // load querys names
                loadQueries();
            }
        }



        //***************************   Method  ***************************


        #region loadQueries

        /// <summary>
        /// load all querys file name
        /// </summary>
        private void loadQueries()
        {
            // set search value
            string strSearch = txtSearch.Text;

            // clear listbox
            lstbxQueriesNameTable.Items.Clear();
            lstbxQueriesNameColumn.Items.Clear();


            // get path file
            string[] files = Directory.GetFiles(strPathQueries, "*.sql");



            string strRow;

            // add file name to lstbx
            foreach (string file in files)
            {
                strRow = Path.GetFileNameWithoutExtension(file);

                if (strRow.Contains("جدول"))
                {
                    //  search
                    if (strSearch != "")
                    {
                        if (strRow.Contains(strSearch))
                        { lstbxQueriesNameTable.Items.Add(strRow); }
                    }

                    else { lstbxQueriesNameTable.Items.Add(strRow); }
                }


                if (!strRow.Contains("جدول"))
                {
                    //  search
                    if (strSearch != "")
                    {
                        if (strRow.Contains(strSearch))
                        { lstbxQueriesNameColumn.Items.Add(strRow); }
                    }

                    else { lstbxQueriesNameColumn.Items.Add(strRow); }
                }

            }
        }

        #endregion


        #region Select,Cut,Copy,Paste

        private void Cut_Click(object sender, EventArgs e)
        { txtQuery.Cut(); }


        private void Copy_Click(object sender, EventArgs e)
        { txtQuery.Copy(); }


        private void Paste_Click(object sender, EventArgs e)
        { txtQuery.Paste(); }


        private void Selected_Click(object sender, EventArgs e)
        {
            txtQuery.HideSelection = true;
            txtQuery.SelectAll();
        }



        #endregion

        private void frmQueries_Load(object sender, EventArgs e)
        {

        }


        // search
        private void txtSearch_TextChanged(object sender, EventArgs e)
        { loadQueries(); }



        private void SelectQuery(ListBox lstbxQueriesName)
        {
            //  query text
            txtQuery.Text = File.ReadAllText(strPathQueries+ lstbxQueriesName.Text + ".sql");

            //  query title number
            txtTitleNum.Text = lstbxQueriesName.Text.Substring(0, lstbxQueriesName.Text.IndexOf('_'));

            // query title
            txtTitle.Text = lstbxQueriesName.Text.Replace(txtTitleNum.Text + "_", "");
        }

        private void lstbxQueriesNameColumn_SelectedIndexChanged(object sender, EventArgs e)
        { SelectQuery(lstbxQueriesNameColumn); }

        private void lstbxQueriesNameTable_SelectedIndexChanged(object sender, EventArgs e)
        { SelectQuery(lstbxQueriesNameTable); }

        private void btnSetNumbers_Click(object sender, EventArgs e)
        {
            // get all path file
            string[] files = Directory.GetFiles(strPathQueries, "*.sql");

            List<string> lstOldName = new List<string>();
            List<string> lstNewName = new List<string>();

            // add file name to lstbx
            foreach (string file in files)
                lstOldName.Add(Path.GetFileNameWithoutExtension(file));



            int intRC = lstOldName.Count;

            for (int i = 0; i < intRC; i++)
            {
                int intchar = lstOldName[i].IndexOf("_");
                string strNewNumber = (i + 1).ToString().PadLeft(2, '0');
                string strNewName = lstOldName[i].Substring(intchar, lstOldName[i].Length - intchar);
                lstNewName.Add(strNewNumber + strNewName);
                string strReplaceOld = strPathQueries + lstOldName[i] + ".sql";
                string strReplaceNew = strPathQueries  + lstNewName[i] + ".sql";
                File.Move(strReplaceOld, strReplaceNew);
            }




        }
    }
}
