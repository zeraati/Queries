using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Querys
{
    public partial class frmQuerys : Form
    {

        string strPathQuerys = @"..\Querys";

        public frmQuerys()
        {
            InitializeComponent();

            //load querys file name
            loadQuerys();
        }


        // save query
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "")
            {
                // title number
                string strTitleNum = txtTitleNum.Text.PadLeft(2, '0');

                // save query text
                File.WriteAllText(strPathQuerys + @"\" + strTitleNum + "-" + txtTitle.Text + ".sql", txtQuery.Text, Encoding.UTF8);

                //load querys file name
                loadQuerys();
            }

            else { MessageBox.Show("عنوان فایل را وارد کنید", "هشدار"); }

        }


        // del query
        private void btnDel_Click(object sender, EventArgs e)
        {
            // warrning del massage
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("آیا کوئری [" + lstbxQuerysNameColumn.Text + "] حذف شود ", "!هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            if (dr == DialogResult.Yes)
            {
                // del query file
                File.Delete(strPathQuerys + @"\" + lstbxQuerysNameColumn.Text + ".sql");

                // load querys names
                loadQuerys();
            }
        }



        //***************************   Method  ***************************


        #region loadQuerys

        /// <summary>
        /// load all querys file name
        /// </summary>
        private void loadQuerys()
        {
            // set search value
            string strSearch = txtSearch.Text;

            // clear listbox
            lstbxQuerysNameTable.Items.Clear();
            lstbxQuerysNameColumn.Items.Clear();


            // get path file
            string[] files = Directory.GetFiles(strPathQuerys, "*.sql");



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
                        { lstbxQuerysNameTable.Items.Add(strRow); }
                    }

                    else { lstbxQuerysNameTable.Items.Add(strRow); }
                }


                if (!strRow.Contains("جدول"))
                {
                    //  search
                    if (strSearch != "")
                    {
                        if (strRow.Contains(strSearch))
                        { lstbxQuerysNameColumn.Items.Add(strRow); }
                    }

                    else { lstbxQuerysNameColumn.Items.Add(strRow); }
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

        private void frmQuerys_Load(object sender, EventArgs e)
        {

        }


        // search
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {loadQuerys();}



        private void SelectQuery(ListBox lstbxQuerysName)
        {
            //  query text
            txtQuery.Text = File.ReadAllText(strPathQuerys + @"\" + lstbxQuerysName.Text + ".sql");

            //  query title number
            txtTitleNum.Text = lstbxQuerysName.Text.Substring(0, lstbxQuerysName.Text.IndexOf('-'));

            // query title
            txtTitle.Text = lstbxQuerysName.Text.Replace(txtTitleNum.Text + "-", "");
        }

        private void lstbxQuerysNameColumn_SelectedIndexChanged(object sender, EventArgs e)
        {SelectQuery(lstbxQuerysNameColumn);}

        private void lstbxQuerysNameTable_SelectedIndexChanged(object sender, EventArgs e)
        {SelectQuery(lstbxQuerysNameTable);}
    }
}
