namespace Queries
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDBName = new System.Windows.Forms.Label();
            this.cmbDBNames = new System.Windows.Forms.ComboBox();
            this.mnsTools = new System.Windows.Forms.MenuStrip();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.اتصالToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سرورمحلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQry = new System.Windows.Forms.ToolStripMenuItem();
            this.chbRemember = new System.Windows.Forms.CheckBox();
            this.chlbxQueryFileName = new System.Windows.Forms.CheckedListBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.cmbRoidad = new System.Windows.Forms.ComboBox();
            this.lblRoidad = new System.Windows.Forms.Label();
            this.grbQry = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbQryTyp = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtFilterQueryFileName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.cmbTBName = new System.Windows.Forms.ComboBox();
            this.btnDelRdd = new System.Windows.Forms.Button();
            this.lblFirstQuery = new System.Windows.Forms.Label();
            this.cmbFrstQry = new System.Windows.Forms.ComboBox();
            this.lblTBName = new System.Windows.Forms.Label();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.grbSvrConn = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.mnsTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.grbQry.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grbSvrConn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(8, 21);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(103, 28);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "اتصال (Ctrl+R)";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(400, 22);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(174, 28);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(190, 22);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(174, 28);
            this.txtPass.TabIndex = 3;
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(643, 22);
            this.cmbServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbServer.Size = new System.Drawing.Size(174, 28);
            this.cmbServer.TabIndex = 1;
            this.cmbServer.SelectedIndexChanged += new System.EventHandler(this.cmbServer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(823, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "نام سرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "نام کاربری";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "رمز";
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(38, 99);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(32, 20);
            this.lblDBName.TabIndex = 12;
            this.lblDBName.Text = "بانک";
            // 
            // cmbDBNames
            // 
            this.cmbDBNames.FormattingEnabled = true;
            this.cmbDBNames.Location = new System.Drawing.Point(76, 96);
            this.cmbDBNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDBNames.Name = "cmbDBNames";
            this.cmbDBNames.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDBNames.Size = new System.Drawing.Size(174, 28);
            this.cmbDBNames.TabIndex = 5;
            this.cmbDBNames.SelectedIndexChanged += new System.EventHandler(this.cmbDBNames_SelectedIndexChanged);
            // 
            // mnsTools
            // 
            this.mnsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTools});
            this.mnsTools.Location = new System.Drawing.Point(0, 0);
            this.mnsTools.Name = "mnsTools";
            this.mnsTools.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnsTools.Size = new System.Drawing.Size(908, 25);
            this.mnsTools.TabIndex = 15;
            this.mnsTools.Text = "ابزار ها";
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اتصالToolStripMenuItem,
            this.سرورمحلیToolStripMenuItem,
            this.tsmiQry});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(48, 19);
            this.tsmiTools.Text = "ابزارها";
            // 
            // اتصالToolStripMenuItem
            // 
            this.اتصالToolStripMenuItem.Name = "اتصالToolStripMenuItem";
            this.اتصالToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.اتصالToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.اتصالToolStripMenuItem.Text = "اتصال";
            // 
            // سرورمحلیToolStripMenuItem
            // 
            this.سرورمحلیToolStripMenuItem.Name = "سرورمحلیToolStripMenuItem";
            this.سرورمحلیToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.سرورمحلیToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.سرورمحلیToolStripMenuItem.Text = "سرور محلی";
            // 
            // tsmiQry
            // 
            this.tsmiQry.Name = "tsmiQry";
            this.tsmiQry.Size = new System.Drawing.Size(169, 22);
            this.tsmiQry.Text = "کوئری";
            this.tsmiQry.Click += new System.EventHandler(this.tsmiQry_Click);
            // 
            // chbRemember
            // 
            this.chbRemember.AutoSize = true;
            this.chbRemember.Location = new System.Drawing.Point(129, 25);
            this.chbRemember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbRemember.Name = "chbRemember";
            this.chbRemember.Size = new System.Drawing.Size(55, 24);
            this.chbRemember.TabIndex = 6;
            this.chbRemember.Text = "ذخیره";
            this.chbRemember.UseVisualStyleBackColor = true;
            // 
            // chlbxQueryFileName
            // 
            this.chlbxQueryFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chlbxQueryFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chlbxQueryFileName.CheckOnClick = true;
            this.chlbxQueryFileName.FormattingEnabled = true;
            this.chlbxQueryFileName.HorizontalScrollbar = true;
            this.chlbxQueryFileName.Location = new System.Drawing.Point(0, 29);
            this.chlbxQueryFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chlbxQueryFileName.Name = "chlbxQueryFileName";
            this.chlbxQueryFileName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chlbxQueryFileName.Size = new System.Drawing.Size(321, 230);
            this.chlbxQueryFileName.TabIndex = 18;
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(10, 98);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(526, 290);
            this.dgvResult.TabIndex = 19;
            // 
            // cmbRoidad
            // 
            this.cmbRoidad.FormattingEnabled = true;
            this.cmbRoidad.Location = new System.Drawing.Point(408, 61);
            this.cmbRoidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRoidad.Name = "cmbRoidad";
            this.cmbRoidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbRoidad.Size = new System.Drawing.Size(267, 28);
            this.cmbRoidad.TabIndex = 23;
            this.cmbRoidad.SelectedIndexChanged += new System.EventHandler(this.cmbRoidad_SelectedIndexChanged);
            // 
            // lblRoidad
            // 
            this.lblRoidad.AutoSize = true;
            this.lblRoidad.Location = new System.Drawing.Point(676, 64);
            this.lblRoidad.Name = "lblRoidad";
            this.lblRoidad.Size = new System.Drawing.Size(89, 20);
            this.lblRoidad.TabIndex = 24;
            this.lblRoidad.Text = "انتخاب رویدادها";
            // 
            // grbQry
            // 
            this.grbQry.Controls.Add(this.btnSave);
            this.grbQry.Controls.Add(this.label5);
            this.grbQry.Controls.Add(this.cmbQryTyp);
            this.grbQry.Controls.Add(this.tabControl1);
            this.grbQry.Controls.Add(this.cmbTBName);
            this.grbQry.Controls.Add(this.btnDelRdd);
            this.grbQry.Controls.Add(this.lblFirstQuery);
            this.grbQry.Controls.Add(this.cmbFrstQry);
            this.grbQry.Controls.Add(this.lblTBName);
            this.grbQry.Controls.Add(this.txtTop);
            this.grbQry.Controls.Add(this.btnRun);
            this.grbQry.Controls.Add(this.dgvResult);
            this.grbQry.Controls.Add(this.lblRoidad);
            this.grbQry.Controls.Add(this.cmbRoidad);
            this.grbQry.Location = new System.Drawing.Point(14, 142);
            this.grbQry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbQry.Name = "grbQry";
            this.grbQry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbQry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbQry.Size = new System.Drawing.Size(880, 396);
            this.grbQry.TabIndex = 25;
            this.grbQry.TabStop = false;
            this.grbQry.Text = "Query";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(298, 60);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "ذخیره کردن";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(844, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "نوع";
            // 
            // cmbQryTyp
            // 
            this.cmbQryTyp.FormattingEnabled = true;
            this.cmbQryTyp.Items.AddRange(new object[] {
            "ستون",
            "جدول"});
            this.cmbQryTyp.Location = new System.Drawing.Point(759, 21);
            this.cmbQryTyp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbQryTyp.Name = "cmbQryTyp";
            this.cmbQryTyp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbQryTyp.Size = new System.Drawing.Size(84, 28);
            this.cmbQryTyp.TabIndex = 34;
            this.cmbQryTyp.Text = "ستون";
            this.cmbQryTyp.SelectedIndexChanged += new System.EventHandler(this.cmbQryTyp_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(549, 98);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(329, 290);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtFilterQueryFileName);
            this.tabPage1.Controls.Add(this.chlbxQueryFileName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(321, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "کوئری";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtFilterQueryFileName
            // 
            this.txtFilterQueryFileName.Location = new System.Drawing.Point(0, 0);
            this.txtFilterQueryFileName.Name = "txtFilterQueryFileName";
            this.txtFilterQueryFileName.Size = new System.Drawing.Size(321, 28);
            this.txtFilterQueryFileName.TabIndex = 19;
            this.txtFilterQueryFileName.Text = "19";
            this.txtFilterQueryFileName.TextChanged += new System.EventHandler(this.txtFilterQueryFileName_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(321, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "نتیجه عملیات";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstReport
            // 
            this.lstReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstReport.FormattingEnabled = true;
            this.lstReport.HorizontalScrollbar = true;
            this.lstReport.ItemHeight = 20;
            this.lstReport.Location = new System.Drawing.Point(0, 0);
            this.lstReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstReport.Name = "lstReport";
            this.lstReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstReport.Size = new System.Drawing.Size(321, 300);
            this.lstReport.TabIndex = 0;
            this.lstReport.SelectedIndexChanged += new System.EventHandler(this.lstReport_SelectedIndexChanged);
            // 
            // cmbTBName
            // 
            this.cmbTBName.FormattingEnabled = true;
            this.cmbTBName.Location = new System.Drawing.Point(201, 21);
            this.cmbTBName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTBName.Name = "cmbTBName";
            this.cmbTBName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTBName.Size = new System.Drawing.Size(140, 28);
            this.cmbTBName.TabIndex = 30;
            this.cmbTBName.Text = "95-03-05";
            this.cmbTBName.SelectedIndexChanged += new System.EventHandler(this.cmbTBName_SelectedIndexChanged);
            // 
            // btnDelRdd
            // 
            this.btnDelRdd.Location = new System.Drawing.Point(199, 60);
            this.btnDelRdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelRdd.Name = "btnDelRdd";
            this.btnDelRdd.Size = new System.Drawing.Size(87, 28);
            this.btnDelRdd.TabIndex = 32;
            this.btnDelRdd.Text = "حذف رویداد";
            this.btnDelRdd.UseVisualStyleBackColor = true;
            this.btnDelRdd.Click += new System.EventHandler(this.btnDelRdd_Click);
            // 
            // lblFirstQuery
            // 
            this.lblFirstQuery.AutoSize = true;
            this.lblFirstQuery.Location = new System.Drawing.Point(681, 24);
            this.lblFirstQuery.Name = "lblFirstQuery";
            this.lblFirstQuery.Size = new System.Drawing.Size(65, 20);
            this.lblFirstQuery.TabIndex = 31;
            this.lblFirstQuery.Text = "اولین کوئری";
            // 
            // cmbFrstQry
            // 
            this.cmbFrstQry.DropDownWidth = 500;
            this.cmbFrstQry.FormattingEnabled = true;
            this.cmbFrstQry.Location = new System.Drawing.Point(408, 21);
            this.cmbFrstQry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFrstQry.Name = "cmbFrstQry";
            this.cmbFrstQry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFrstQry.Size = new System.Drawing.Size(267, 28);
            this.cmbFrstQry.TabIndex = 30;
            this.cmbFrstQry.SelectedIndexChanged += new System.EventHandler(this.cmbFrstQry_SelectedIndexChanged);
            // 
            // lblTBName
            // 
            this.lblTBName.AutoSize = true;
            this.lblTBName.Location = new System.Drawing.Point(347, 24);
            this.lblTBName.Name = "lblTBName";
            this.lblTBName.Size = new System.Drawing.Size(38, 20);
            this.lblTBName.TabIndex = 29;
            this.lblTBName.Text = "جدول";
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(8, 21);
            this.txtTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTop.Name = "txtTop";
            this.txtTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTop.Size = new System.Drawing.Size(39, 28);
            this.txtTop.TabIndex = 27;
            this.txtTop.Text = "20";
            this.txtTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(53, 20);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(103, 28);
            this.btnRun.TabIndex = 25;
            this.btnRun.Text = "اجرا";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtQuery.Location = new System.Drawing.Point(262, 92);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuery.Size = new System.Drawing.Size(574, 56);
            this.txtQuery.TabIndex = 37;
            // 
            // grbSvrConn
            // 
            this.grbSvrConn.Controls.Add(this.cmbServer);
            this.grbSvrConn.Controls.Add(this.btnConnect);
            this.grbSvrConn.Controls.Add(this.txtUser);
            this.grbSvrConn.Controls.Add(this.txtPass);
            this.grbSvrConn.Controls.Add(this.label1);
            this.grbSvrConn.Controls.Add(this.chbRemember);
            this.grbSvrConn.Controls.Add(this.label2);
            this.grbSvrConn.Controls.Add(this.label3);
            this.grbSvrConn.Location = new System.Drawing.Point(14, 25);
            this.grbSvrConn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSvrConn.Name = "grbSvrConn";
            this.grbSvrConn.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSvrConn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbSvrConn.Size = new System.Drawing.Size(879, 62);
            this.grbSvrConn.TabIndex = 28;
            this.grbSvrConn.TabStop = false;
            this.grbSvrConn.Text = "Server Conn";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(842, 91);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(51, 57);
            this.btnCopy.TabIndex = 25;
            this.btnCopy.Text = "کپی";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 540);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.grbSvrConn);
            this.Controls.Add(this.grbQry);
            this.Controls.Add(this.mnsTools);
            this.Controls.Add(this.lblDBName);
            this.Controls.Add(this.cmbDBNames);
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsTools;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queries";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsTools.ResumeLayout(false);
            this.mnsTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.grbQry.ResumeLayout(false);
            this.grbQry.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grbSvrConn.ResumeLayout(false);
            this.grbSvrConn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.ComboBox cmbDBNames;
        private System.Windows.Forms.MenuStrip mnsTools;
        private System.Windows.Forms.CheckBox chbRemember;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem اتصالToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سرورمحلیToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox chlbxQueryFileName;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.ComboBox cmbRoidad;
        private System.Windows.Forms.Label lblRoidad;
        private System.Windows.Forms.GroupBox grbQry;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ToolStripMenuItem tsmiQry;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label lblTBName;
        private System.Windows.Forms.GroupBox grbSvrConn;
        private System.Windows.Forms.Label lblFirstQuery;
        private System.Windows.Forms.ComboBox cmbFrstQry;
        private System.Windows.Forms.Button btnDelRdd;
        private System.Windows.Forms.ComboBox cmbTBName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbQryTyp;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtFilterQueryFileName;
    }
}

