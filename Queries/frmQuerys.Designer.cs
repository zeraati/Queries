namespace Querys
{
    partial class frmQuerys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstbxQuerysNameColumn = new System.Windows.Forms.ListBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtTitleNum = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Selected = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstbxQuerysNameTable = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(113, 23);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(352, 27);
            this.txtTitle.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "ذخیره دستور";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstbxQuerysNameColumn
            // 
            this.lstbxQuerysNameColumn.FormattingEnabled = true;
            this.lstbxQuerysNameColumn.ItemHeight = 19;
            this.lstbxQuerysNameColumn.Location = new System.Drawing.Point(531, 98);
            this.lstbxQuerysNameColumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstbxQuerysNameColumn.Name = "lstbxQuerysNameColumn";
            this.lstbxQuerysNameColumn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstbxQuerysNameColumn.Size = new System.Drawing.Size(297, 213);
            this.lstbxQuerysNameColumn.TabIndex = 6;
            this.lstbxQuerysNameColumn.SelectedIndexChanged += new System.EventHandler(this.lstbxQuerysNameColumn_SelectedIndexChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(531, 18);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(297, 34);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "حذف";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtTitleNum
            // 
            this.txtTitleNum.Location = new System.Drawing.Point(471, 23);
            this.txtTitleNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitleNum.Name = "txtTitleNum";
            this.txtTitleNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitleNum.Size = new System.Drawing.Size(46, 27);
            this.txtTitleNum.TabIndex = 8;
            // 
            // txtQuery
            // 
            this.txtQuery.ContextMenuStrip = this.contextMenuStrip1;
            this.txtQuery.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtQuery.Location = new System.Drawing.Point(20, 60);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(497, 453);
            this.txtQuery.TabIndex = 9;
            this.txtQuery.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cut,
            this.Copy,
            this.Paste,
            this.Selected});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 92);
            // 
            // Cut
            // 
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(119, 22);
            this.Cut.Text = "Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(119, 22);
            this.Copy.Text = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(119, 22);
            this.Paste.Text = "Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Selected
            // 
            this.Selected.Name = "Selected";
            this.Selected.Size = new System.Drawing.Size(119, 22);
            this.Selected.Text = "SelectAll";
            this.Selected.Click += new System.EventHandler(this.Selected_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(531, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(297, 28);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lstbxQuerysNameTable
            // 
            this.lstbxQuerysNameTable.FormattingEnabled = true;
            this.lstbxQuerysNameTable.ItemHeight = 19;
            this.lstbxQuerysNameTable.Location = new System.Drawing.Point(531, 319);
            this.lstbxQuerysNameTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstbxQuerysNameTable.Name = "lstbxQuerysNameTable";
            this.lstbxQuerysNameTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstbxQuerysNameTable.Size = new System.Drawing.Size(297, 194);
            this.lstbxQuerysNameTable.TabIndex = 6;
            this.lstbxQuerysNameTable.SelectedIndexChanged += new System.EventHandler(this.lstbxQuerysNameTable_SelectedIndexChanged);
            // 
            // frmQuerys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 523);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.txtTitleNum);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lstbxQuerysNameTable);
            this.Controls.Add(this.lstbxQuerysNameColumn);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("IRANSans", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQuerys";
            this.Text = "Querys";
            this.Load += new System.EventHandler(this.frmQuerys_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstbxQuerysNameColumn;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtTitleNum;
        private System.Windows.Forms.RichTextBox txtQuery;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Selected;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstbxQuerysNameTable;
    }
}