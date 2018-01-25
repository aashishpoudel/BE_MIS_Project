namespace MIS
{
    partial class MISmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MISmain));
            this.cmbbxdsplsel = new System.Windows.Forms.ComboBox();
            this.pnlservices = new System.Windows.Forms.Panel();
            this.chkbxservicesall = new System.Windows.Forms.CheckBox();
            this.chkbxuan = new System.Windows.Forms.CheckBox();
            this.chkbxhcd = new System.Windows.Forms.CheckBox();
            this.chkbxafs = new System.Windows.Forms.CheckBox();
            this.chkbxpcl = new System.Windows.Forms.CheckBox();
            this.chkbxpcc = new System.Windows.Forms.CheckBox();
            this.lblservices = new System.Windows.Forms.Label();
            this.paneluser = new System.Windows.Forms.Panel();
            this.lblSummaryof = new System.Windows.Forms.Label();
            this.cmbBoxSummary = new System.Windows.Forms.ComboBox();
            this.dateTimePickerend = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerstart = new System.Windows.Forms.DateTimePicker();
            this.txtbxcardno = new System.Windows.Forms.TextBox();
            this.chkbxcardno = new System.Windows.Forms.CheckBox();
            this.lblenddate = new System.Windows.Forms.Label();
            this.lblstartdate = new System.Windows.Forms.Label();
            this.txtbxcallingparty = new System.Windows.Forms.TextBox();
            this.chkbxcallingparty = new System.Windows.Forms.CheckBox();
            this.lbluserinput = new System.Windows.Forms.Label();
            this.pnldisplayselection = new System.Windows.Forms.Panel();
            this.chkbxselall = new System.Windows.Forms.CheckBox();
            this.chkbxecc = new System.Windows.Forms.CheckBox();
            this.chkbxbcc = new System.Windows.Forms.CheckBox();
            this.chkbxfcnt = new System.Windows.Forms.CheckBox();
            this.chkbxssno = new System.Windows.Forms.CheckBox();
            this.chkbxuid = new System.Windows.Forms.CheckBox();
            this.chkbxscpt = new System.Windows.Forms.CheckBox();
            this.chkbxccls = new System.Windows.Forms.CheckBox();
            this.chkbxccst = new System.Windows.Forms.CheckBox();
            this.chkbxdur = new System.Windows.Forms.CheckBox();
            this.chkbxedt = new System.Windows.Forms.CheckBox();
            this.chkbxsdt = new System.Windows.Forms.CheckBox();
            this.chkbxshp = new System.Windows.Forms.CheckBox();
            this.chkbxseltp = new System.Windows.Forms.CheckBox();
            this.chkbxselcp = new System.Windows.Forms.CheckBox();
            this.menustripmain = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbldiaplyset = new System.Windows.Forms.Label();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusstrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cmbbxmonthsel = new System.Windows.Forms.ComboBox();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.pnlservices.SuspendLayout();
            this.paneluser.SuspendLayout();
            this.pnldisplayselection.SuspendLayout();
            this.menustripmain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbbxdsplsel
            // 
            this.cmbbxdsplsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxdsplsel.Items.AddRange(new object[] {
            "Normal Report",
            "Monthly Report",
            "Annual Report",
            "Summary Report"});
            this.cmbbxdsplsel.Location = new System.Drawing.Point(819, 51);
            this.cmbbxdsplsel.Name = "cmbbxdsplsel";
            this.cmbbxdsplsel.Size = new System.Drawing.Size(103, 21);
            this.cmbbxdsplsel.TabIndex = 31;
            this.cmbbxdsplsel.Text = "Select Report";
            this.cmbbxdsplsel.SelectedIndexChanged += new System.EventHandler(this.cmbbxdsplsel_SelectedIndexChanged);
            this.cmbbxdsplsel.TextChanged += new System.EventHandler(this.cmbbxdsplsel_TextChanged);
            // 
            // pnlservices
            // 
            this.pnlservices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlservices.Controls.Add(this.chkbxservicesall);
            this.pnlservices.Controls.Add(this.chkbxuan);
            this.pnlservices.Controls.Add(this.chkbxhcd);
            this.pnlservices.Controls.Add(this.chkbxafs);
            this.pnlservices.Controls.Add(this.chkbxpcl);
            this.pnlservices.Controls.Add(this.chkbxpcc);
            this.pnlservices.Location = new System.Drawing.Point(10, 51);
            this.pnlservices.Name = "pnlservices";
            this.pnlservices.Size = new System.Drawing.Size(187, 172);
            this.pnlservices.TabIndex = 0;
            // 
            // chkbxservicesall
            // 
            this.chkbxservicesall.AutoSize = true;
            this.chkbxservicesall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxservicesall.Location = new System.Drawing.Point(14, 141);
            this.chkbxservicesall.Name = "chkbxservicesall";
            this.chkbxservicesall.Size = new System.Drawing.Size(76, 19);
            this.chkbxservicesall.TabIndex = 5;
            this.chkbxservicesall.Text = "Select All";
            this.chkbxservicesall.UseVisualStyleBackColor = true;
            this.chkbxservicesall.CheckedChanged += new System.EventHandler(this.chkbxservicesall_CheckedChanged);
            // 
            // chkbxuan
            // 
            this.chkbxuan.AutoSize = true;
            this.chkbxuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxuan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbxuan.Location = new System.Drawing.Point(14, 119);
            this.chkbxuan.Name = "chkbxuan";
            this.chkbxuan.Size = new System.Drawing.Size(166, 19);
            this.chkbxuan.TabIndex = 4;
            this.chkbxuan.Text = "Universal Access Number";
            this.chkbxuan.UseVisualStyleBackColor = true;
            this.chkbxuan.CheckedChanged += new System.EventHandler(this.chkbxuan_CheckedChanged);
            // 
            // chkbxhcd
            // 
            this.chkbxhcd.AutoSize = true;
            this.chkbxhcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxhcd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbxhcd.Location = new System.Drawing.Point(14, 83);
            this.chkbxhcd.Name = "chkbxhcd";
            this.chkbxhcd.Size = new System.Drawing.Size(104, 34);
            this.chkbxhcd.TabIndex = 3;
            this.chkbxhcd.Text = "Home Country\r\nDirect Service";
            this.chkbxhcd.UseVisualStyleBackColor = true;
            this.chkbxhcd.CheckedChanged += new System.EventHandler(this.chkbxhcd_CheckedChanged);
            // 
            // chkbxafs
            // 
            this.chkbxafs.AutoSize = true;
            this.chkbxafs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxafs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbxafs.Location = new System.Drawing.Point(14, 49);
            this.chkbxafs.Name = "chkbxafs";
            this.chkbxafs.Size = new System.Drawing.Size(110, 34);
            this.chkbxafs.TabIndex = 2;
            this.chkbxafs.Text = "Advanced Free \r\nPhone Service";
            this.chkbxafs.UseVisualStyleBackColor = true;
            this.chkbxafs.CheckedChanged += new System.EventHandler(this.chkbxafs_CheckedChanged);
            // 
            // chkbxpcl
            // 
            this.chkbxpcl.AutoSize = true;
            this.chkbxpcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxpcl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbxpcl.Location = new System.Drawing.Point(14, 30);
            this.chkbxpcl.Name = "chkbxpcl";
            this.chkbxpcl.Size = new System.Drawing.Size(123, 19);
            this.chkbxpcl.TabIndex = 1;
            this.chkbxpcl.Text = "PSTN Credit Limit";
            this.chkbxpcl.UseVisualStyleBackColor = true;
            this.chkbxpcl.CheckedChanged += new System.EventHandler(this.chkbxpcl_CheckedChanged);
            // 
            // chkbxpcc
            // 
            this.chkbxpcc.AutoSize = true;
            this.chkbxpcc.Checked = true;
            this.chkbxpcc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxpcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxpcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbxpcc.Location = new System.Drawing.Point(14, 4);
            this.chkbxpcc.Name = "chkbxpcc";
            this.chkbxpcc.Size = new System.Drawing.Size(143, 19);
            this.chkbxpcc.TabIndex = 0;
            this.chkbxpcc.Text = "Pre-paid Calling Card";
            this.chkbxpcc.UseVisualStyleBackColor = true;
            this.chkbxpcc.CheckedChanged += new System.EventHandler(this.chkbxpcc_CheckedChanged);
            // 
            // lblservices
            // 
            this.lblservices.AutoSize = true;
            this.lblservices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservices.Location = new System.Drawing.Point(67, 33);
            this.lblservices.Name = "lblservices";
            this.lblservices.Size = new System.Drawing.Size(79, 15);
            this.lblservices.TabIndex = 1;
            this.lblservices.Text = "IN Services";
            // 
            // paneluser
            // 
            this.paneluser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneluser.Controls.Add(this.lblSummaryof);
            this.paneluser.Controls.Add(this.cmbBoxSummary);
            this.paneluser.Controls.Add(this.dateTimePickerend);
            this.paneluser.Controls.Add(this.dateTimePickerstart);
            this.paneluser.Controls.Add(this.txtbxcardno);
            this.paneluser.Controls.Add(this.chkbxcardno);
            this.paneluser.Controls.Add(this.lblenddate);
            this.paneluser.Controls.Add(this.lblstartdate);
            this.paneluser.Controls.Add(this.txtbxcallingparty);
            this.paneluser.Controls.Add(this.chkbxcallingparty);
            this.paneluser.Location = new System.Drawing.Point(205, 51);
            this.paneluser.Name = "paneluser";
            this.paneluser.Size = new System.Drawing.Size(285, 172);
            this.paneluser.TabIndex = 2;
            this.paneluser.Paint += new System.Windows.Forms.PaintEventHandler(this.paneluser_Paint);
            // 
            // lblSummaryof
            // 
            this.lblSummaryof.AutoSize = true;
            this.lblSummaryof.Location = new System.Drawing.Point(7, 78);
            this.lblSummaryof.Name = "lblSummaryof";
            this.lblSummaryof.Size = new System.Drawing.Size(72, 13);
            this.lblSummaryof.TabIndex = 20;
            this.lblSummaryof.Text = "Summary of";
            // 
            // cmbBoxSummary
            // 
            this.cmbBoxSummary.FormattingEnabled = true;
            this.cmbBoxSummary.Items.AddRange(new object[] {
            "ChargeClass Wise",
            "Day Wise"});
            this.cmbBoxSummary.Location = new System.Drawing.Point(91, 74);
            this.cmbBoxSummary.Name = "cmbBoxSummary";
            this.cmbBoxSummary.Size = new System.Drawing.Size(132, 21);
            this.cmbBoxSummary.TabIndex = 19;
            this.cmbBoxSummary.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSummary_SelectedIndexChanged);
            // 
            // dateTimePickerend
            // 
            this.dateTimePickerend.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerend.Location = new System.Drawing.Point(63, 145);
            this.dateTimePickerend.Name = "dateTimePickerend";
            this.dateTimePickerend.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerend.TabIndex = 15;
            this.dateTimePickerend.Value = new System.DateTime(2007, 8, 4, 0, 0, 0, 0);
            this.dateTimePickerend.ValueChanged += new System.EventHandler(this.dateTimePickerend_ValueChanged);
            // 
            // dateTimePickerstart
            // 
            this.dateTimePickerstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerstart.Location = new System.Drawing.Point(63, 115);
            this.dateTimePickerstart.Name = "dateTimePickerstart";
            this.dateTimePickerstart.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerstart.TabIndex = 13;
            this.dateTimePickerstart.Value = new System.DateTime(2007, 8, 4, 0, 0, 0, 0);
            this.dateTimePickerstart.ValueChanged += new System.EventHandler(this.dateTimePickerstart_ValueChanged);
            // 
            // txtbxcardno
            // 
            this.txtbxcardno.Enabled = false;
            this.txtbxcardno.Location = new System.Drawing.Point(116, 34);
            this.txtbxcardno.MaxLength = 9;
            this.txtbxcardno.Name = "txtbxcardno";
            this.txtbxcardno.Size = new System.Drawing.Size(160, 20);
            this.txtbxcardno.TabIndex = 18;
            this.txtbxcardno.TextChanged += new System.EventHandler(this.txtbxcardno_TextChanged);
            // 
            // chkbxcardno
            // 
            this.chkbxcardno.AutoSize = true;
            this.chkbxcardno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxcardno.Location = new System.Drawing.Point(10, 37);
            this.chkbxcardno.Name = "chkbxcardno";
            this.chkbxcardno.Size = new System.Drawing.Size(68, 17);
            this.chkbxcardno.TabIndex = 12;
            this.chkbxcardno.Text = "Card No.";
            this.chkbxcardno.UseVisualStyleBackColor = true;
            this.chkbxcardno.CheckedChanged += new System.EventHandler(this.chkbxcardno_CheckedChanged);
            // 
            // lblenddate
            // 
            this.lblenddate.AutoSize = true;
            this.lblenddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenddate.Location = new System.Drawing.Point(7, 145);
            this.lblenddate.Name = "lblenddate";
            this.lblenddate.Size = new System.Drawing.Size(52, 13);
            this.lblenddate.TabIndex = 14;
            this.lblenddate.Text = "End Date";
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartdate.Location = new System.Drawing.Point(7, 117);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(55, 13);
            this.lblstartdate.TabIndex = 5;
            this.lblstartdate.Text = "Start Date";
            // 
            // txtbxcallingparty
            // 
            this.txtbxcallingparty.Enabled = false;
            this.txtbxcallingparty.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbxcallingparty.Location = new System.Drawing.Point(116, 8);
            this.txtbxcallingparty.Name = "txtbxcallingparty";
            this.txtbxcallingparty.Size = new System.Drawing.Size(160, 20);
            this.txtbxcallingparty.TabIndex = 7;
            // 
            // chkbxcallingparty
            // 
            this.chkbxcallingparty.AutoSize = true;
            this.chkbxcallingparty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxcallingparty.Location = new System.Drawing.Point(9, 8);
            this.chkbxcallingparty.Name = "chkbxcallingparty";
            this.chkbxcallingparty.Size = new System.Drawing.Size(102, 17);
            this.chkbxcallingparty.TabIndex = 6;
            this.chkbxcallingparty.Text = "Calling Party no.";
            this.chkbxcallingparty.UseVisualStyleBackColor = true;
            this.chkbxcallingparty.CheckedChanged += new System.EventHandler(this.chkbxcallingparty_CheckedChanged);
            // 
            // lbluserinput
            // 
            this.lbluserinput.AutoSize = true;
            this.lbluserinput.Location = new System.Drawing.Point(301, 33);
            this.lbluserinput.Name = "lbluserinput";
            this.lbluserinput.Size = new System.Drawing.Size(72, 13);
            this.lbluserinput.TabIndex = 3;
            this.lbluserinput.Text = "User Inputs";
            // 
            // pnldisplayselection
            // 
            this.pnldisplayselection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnldisplayselection.Controls.Add(this.chkbxselall);
            this.pnldisplayselection.Controls.Add(this.chkbxecc);
            this.pnldisplayselection.Controls.Add(this.chkbxbcc);
            this.pnldisplayselection.Controls.Add(this.chkbxfcnt);
            this.pnldisplayselection.Controls.Add(this.chkbxssno);
            this.pnldisplayselection.Controls.Add(this.chkbxuid);
            this.pnldisplayselection.Controls.Add(this.chkbxscpt);
            this.pnldisplayselection.Controls.Add(this.chkbxccls);
            this.pnldisplayselection.Controls.Add(this.chkbxccst);
            this.pnldisplayselection.Controls.Add(this.chkbxdur);
            this.pnldisplayselection.Controls.Add(this.chkbxedt);
            this.pnldisplayselection.Controls.Add(this.chkbxsdt);
            this.pnldisplayselection.Controls.Add(this.chkbxshp);
            this.pnldisplayselection.Controls.Add(this.chkbxseltp);
            this.pnldisplayselection.Controls.Add(this.chkbxselcp);
            this.pnldisplayselection.Location = new System.Drawing.Point(499, 51);
            this.pnldisplayselection.Name = "pnldisplayselection";
            this.pnldisplayselection.Size = new System.Drawing.Size(314, 172);
            this.pnldisplayselection.TabIndex = 4;
            // 
            // chkbxselall
            // 
            this.chkbxselall.AutoSize = true;
            this.chkbxselall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxselall.Location = new System.Drawing.Point(97, 147);
            this.chkbxselall.Name = "chkbxselall";
            this.chkbxselall.Size = new System.Drawing.Size(70, 17);
            this.chkbxselall.TabIndex = 30;
            this.chkbxselall.Text = "Select All";
            this.chkbxselall.UseVisualStyleBackColor = true;
            this.chkbxselall.CheckedChanged += new System.EventHandler(this.chkbxselall_CheckedChanged);
            // 
            // chkbxecc
            // 
            this.chkbxecc.AutoSize = true;
            this.chkbxecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxecc.Location = new System.Drawing.Point(159, 131);
            this.chkbxecc.Name = "chkbxecc";
            this.chkbxecc.Size = new System.Drawing.Size(94, 17);
            this.chkbxecc.TabIndex = 29;
            this.chkbxecc.Text = "Extra Call Cost";
            this.chkbxecc.UseVisualStyleBackColor = true;
            this.chkbxecc.CheckedChanged += new System.EventHandler(this.chkbxecc_CheckedChanged);
            // 
            // chkbxbcc
            // 
            this.chkbxbcc.AutoSize = true;
            this.chkbxbcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxbcc.Location = new System.Drawing.Point(159, 108);
            this.chkbxbcc.Name = "chkbxbcc";
            this.chkbxbcc.Size = new System.Drawing.Size(94, 17);
            this.chkbxbcc.TabIndex = 28;
            this.chkbxbcc.Text = "Base Call Cost";
            this.chkbxbcc.UseVisualStyleBackColor = true;
            this.chkbxbcc.CheckedChanged += new System.EventHandler(this.chkbxbcc_CheckedChanged);
            // 
            // chkbxfcnt
            // 
            this.chkbxfcnt.AutoSize = true;
            this.chkbxfcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxfcnt.Location = new System.Drawing.Point(159, 85);
            this.chkbxfcnt.Name = "chkbxfcnt";
            this.chkbxfcnt.Size = new System.Drawing.Size(114, 17);
            this.chkbxfcnt.TabIndex = 27;
            this.chkbxfcnt.Text = "Fee Count (pulses)";
            this.chkbxfcnt.UseVisualStyleBackColor = true;
            this.chkbxfcnt.CheckedChanged += new System.EventHandler(this.chkbxfcnt_CheckedChanged);
            // 
            // chkbxssno
            // 
            this.chkbxssno.AutoSize = true;
            this.chkbxssno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxssno.Location = new System.Drawing.Point(159, 64);
            this.chkbxssno.Name = "chkbxssno";
            this.chkbxssno.Size = new System.Drawing.Size(104, 17);
            this.chkbxssno.TabIndex = 26;
            this.chkbxssno.Text = "Sub Service No.";
            this.chkbxssno.UseVisualStyleBackColor = true;
            this.chkbxssno.CheckedChanged += new System.EventHandler(this.chkbxssno_CheckedChanged);
            // 
            // chkbxuid
            // 
            this.chkbxuid.AutoSize = true;
            this.chkbxuid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxuid.Location = new System.Drawing.Point(159, 44);
            this.chkbxuid.Name = "chkbxuid";
            this.chkbxuid.Size = new System.Drawing.Size(62, 17);
            this.chkbxuid.TabIndex = 25;
            this.chkbxuid.Text = "User ID";
            this.chkbxuid.UseVisualStyleBackColor = true;
            this.chkbxuid.CheckedChanged += new System.EventHandler(this.chkbxuid_CheckedChanged);
            // 
            // chkbxscpt
            // 
            this.chkbxscpt.AutoSize = true;
            this.chkbxscpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxscpt.Location = new System.Drawing.Point(159, 24);
            this.chkbxscpt.Name = "chkbxscpt";
            this.chkbxscpt.Size = new System.Drawing.Size(150, 17);
            this.chkbxscpt.TabIndex = 24;
            this.chkbxscpt.Text = "Specific Charge Part Type";
            this.chkbxscpt.UseVisualStyleBackColor = true;
            this.chkbxscpt.CheckedChanged += new System.EventHandler(this.chkbxscpt_CheckedChanged);
            // 
            // chkbxccls
            // 
            this.chkbxccls.AutoSize = true;
            this.chkbxccls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxccls.Location = new System.Drawing.Point(159, 4);
            this.chkbxccls.Name = "chkbxccls";
            this.chkbxccls.Size = new System.Drawing.Size(88, 17);
            this.chkbxccls.TabIndex = 23;
            this.chkbxccls.Text = "Charge Class";
            this.chkbxccls.UseVisualStyleBackColor = true;
            this.chkbxccls.CheckedChanged += new System.EventHandler(this.chkbxccls_CheckedChanged);
            // 
            // chkbxccst
            // 
            this.chkbxccst.AutoSize = true;
            this.chkbxccst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxccst.Location = new System.Drawing.Point(6, 131);
            this.chkbxccst.Name = "chkbxccst";
            this.chkbxccst.Size = new System.Drawing.Size(105, 17);
            this.chkbxccst.TabIndex = 22;
            this.chkbxccst.Text = "Call Cost in NRs.";
            this.chkbxccst.UseVisualStyleBackColor = true;
            this.chkbxccst.CheckedChanged += new System.EventHandler(this.chkbxccst_CheckedChanged);
            // 
            // chkbxdur
            // 
            this.chkbxdur.AutoSize = true;
            this.chkbxdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxdur.Location = new System.Drawing.Point(5, 108);
            this.chkbxdur.Name = "chkbxdur";
            this.chkbxdur.Size = new System.Drawing.Size(86, 17);
            this.chkbxdur.TabIndex = 21;
            this.chkbxdur.Text = "Call Duration";
            this.chkbxdur.UseVisualStyleBackColor = true;
            this.chkbxdur.CheckedChanged += new System.EventHandler(this.chkbxdur_CheckedChanged);
            // 
            // chkbxedt
            // 
            this.chkbxedt.AutoSize = true;
            this.chkbxedt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxedt.Location = new System.Drawing.Point(5, 85);
            this.chkbxedt.Name = "chkbxedt";
            this.chkbxedt.Size = new System.Drawing.Size(102, 17);
            this.chkbxedt.TabIndex = 20;
            this.chkbxedt.Text = "Stop Date/Time";
            this.chkbxedt.UseVisualStyleBackColor = true;
            this.chkbxedt.CheckedChanged += new System.EventHandler(this.chkbxedt_CheckedChanged);
            // 
            // chkbxsdt
            // 
            this.chkbxsdt.AutoSize = true;
            this.chkbxsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxsdt.Location = new System.Drawing.Point(5, 64);
            this.chkbxsdt.Name = "chkbxsdt";
            this.chkbxsdt.Size = new System.Drawing.Size(102, 17);
            this.chkbxsdt.TabIndex = 19;
            this.chkbxsdt.Text = "Start Date/Time";
            this.chkbxsdt.UseVisualStyleBackColor = true;
            this.chkbxsdt.CheckedChanged += new System.EventHandler(this.chkbxsdt_CheckedChanged);
            // 
            // chkbxshp
            // 
            this.chkbxshp.AutoSize = true;
            this.chkbxshp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxshp.Location = new System.Drawing.Point(5, 44);
            this.chkbxshp.Name = "chkbxshp";
            this.chkbxshp.Size = new System.Drawing.Size(68, 17);
            this.chkbxshp.TabIndex = 18;
            this.chkbxshp.Text = "Card No.";
            this.chkbxshp.UseVisualStyleBackColor = true;
            this.chkbxshp.CheckedChanged += new System.EventHandler(this.chkbxshp_CheckedChanged);
            // 
            // chkbxseltp
            // 
            this.chkbxseltp.AutoSize = true;
            this.chkbxseltp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxseltp.Location = new System.Drawing.Point(5, 24);
            this.chkbxseltp.Name = "chkbxseltp";
            this.chkbxseltp.Size = new System.Drawing.Size(103, 17);
            this.chkbxseltp.TabIndex = 17;
            this.chkbxseltp.Text = "Translated Party";
            this.chkbxseltp.UseVisualStyleBackColor = true;
            this.chkbxseltp.CheckedChanged += new System.EventHandler(this.chkbxseltp_CheckedChanged);
            // 
            // chkbxselcp
            // 
            this.chkbxselcp.AutoSize = true;
            this.chkbxselcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxselcp.Location = new System.Drawing.Point(5, 4);
            this.chkbxselcp.Name = "chkbxselcp";
            this.chkbxselcp.Size = new System.Drawing.Size(84, 17);
            this.chkbxselcp.TabIndex = 16;
            this.chkbxselcp.Text = "Calling Party";
            this.chkbxselcp.UseVisualStyleBackColor = true;
            this.chkbxselcp.CheckedChanged += new System.EventHandler(this.chkbxselcp_CheckedChanged);
            // 
            // menustripmain
            // 
            this.menustripmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menustripmain.Location = new System.Drawing.Point(0, 0);
            this.menustripmain.Name = "menustripmain";
            this.menustripmain.Size = new System.Drawing.Size(924, 24);
            this.menustripmain.TabIndex = 5;
            this.menustripmain.Text = "menuStrip1";
            this.menustripmain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menustripmain_ItemClicked);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.connectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.connectionToolStripMenuItem.Text = "Connect";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.userInputsToolStripMenuItem,
            this.displaySelectionToolStripMenuItem,
            this.allFieldsToolStripMenuItem});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // userInputsToolStripMenuItem
            // 
            this.userInputsToolStripMenuItem.Name = "userInputsToolStripMenuItem";
            this.userInputsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.userInputsToolStripMenuItem.Text = "User Inputs";
            this.userInputsToolStripMenuItem.Click += new System.EventHandler(this.userInputsToolStripMenuItem_Click);
            // 
            // displaySelectionToolStripMenuItem
            // 
            this.displaySelectionToolStripMenuItem.Name = "displaySelectionToolStripMenuItem";
            this.displaySelectionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.displaySelectionToolStripMenuItem.Text = "Display Selection";
            this.displaySelectionToolStripMenuItem.Click += new System.EventHandler(this.displaySelectionToolStripMenuItem_Click);
            // 
            // allFieldsToolStripMenuItem
            // 
            this.allFieldsToolStripMenuItem.Name = "allFieldsToolStripMenuItem";
            this.allFieldsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.allFieldsToolStripMenuItem.Text = "All Fields";
            this.allFieldsToolStripMenuItem.Click += new System.EventHandler(this.allFieldsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridViewToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // gridViewToolStripMenuItem
            // 
            this.gridViewToolStripMenuItem.Checked = true;
            this.gridViewToolStripMenuItem.CheckOnClick = true;
            this.gridViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridViewToolStripMenuItem.Name = "gridViewToolStripMenuItem";
            this.gridViewToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.gridViewToolStripMenuItem.Text = "Grid View";
            this.gridViewToolStripMenuItem.Click += new System.EventHandler(this.gridViewToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.CheckOnClick = true;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // lbldiaplyset
            // 
            this.lbldiaplyset.AutoSize = true;
            this.lbldiaplyset.Location = new System.Drawing.Point(602, 33);
            this.lbldiaplyset.Name = "lbldiaplyset";
            this.lbldiaplyset.Size = new System.Drawing.Size(111, 13);
            this.lbldiaplyset.TabIndex = 6;
            this.lbldiaplyset.Text = "Display Selections";
            // 
            // btndisplay
            // 
            this.btndisplay.Enabled = false;
            this.btndisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(819, 138);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(103, 23);
            this.btndisplay.TabIndex = 32;
            this.btndisplay.Text = "Display Report";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnquit
            // 
            this.btnquit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquit.Location = new System.Drawing.Point(819, 200);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(103, 23);
            this.btnquit.TabIndex = 34;
            this.btnquit.Text = "Quit";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl,
            this.statusstrip,
            this.toolStripProgressBar});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 231);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "                                                ";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // statusstrip
            // 
            this.statusstrip.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.statusstrip.Name = "statusstrip";
            this.statusstrip.Size = new System.Drawing.Size(0, 17);
            this.statusstrip.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnupdate
            // 
            this.btnupdate.Enabled = false;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(819, 170);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(103, 23);
            this.btnupdate.TabIndex = 33;
            this.btnupdate.Text = "Update Data";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cmbbxmonthsel
            // 
            this.cmbbxmonthsel.Enabled = false;
            this.cmbbxmonthsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxmonthsel.FormattingEnabled = true;
            this.cmbbxmonthsel.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbbxmonthsel.Location = new System.Drawing.Point(839, 89);
            this.cmbbxmonthsel.Name = "cmbbxmonthsel";
            this.cmbbxmonthsel.Size = new System.Drawing.Size(50, 21);
            this.cmbbxmonthsel.TabIndex = 35;
            this.cmbbxmonthsel.SelectedIndexChanged += new System.EventHandler(this.cmbbxmonthsel_SelectedIndexChanged);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // MISmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(924, 253);
            this.Controls.Add(this.cmbbxmonthsel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.cmbbxdsplsel);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.lbldiaplyset);
            this.Controls.Add(this.pnldisplayselection);
            this.Controls.Add(this.lbluserinput);
            this.Controls.Add(this.paneluser);
            this.Controls.Add(this.lblservices);
            this.Controls.Add(this.pnlservices);
            this.Controls.Add(this.menustripmain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menustripmain;
            this.MaximizeBox = false;
            this.Name = "MISmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TextChanged += new System.EventHandler(this.MISmain_TextChanged);
            this.Load += new System.EventHandler(this.MISmain_Load);
            this.pnlservices.ResumeLayout(false);
            this.pnlservices.PerformLayout();
            this.paneluser.ResumeLayout(false);
            this.paneluser.PerformLayout();
            this.pnldisplayselection.ResumeLayout(false);
            this.pnldisplayselection.PerformLayout();
            this.menustripmain.ResumeLayout(false);
            this.menustripmain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlservices;
        private System.Windows.Forms.CheckBox chkbxpcc;
        private System.Windows.Forms.Label lblservices;
        private System.Windows.Forms.CheckBox chkbxhcd;
        private System.Windows.Forms.CheckBox chkbxafs;
        private System.Windows.Forms.CheckBox chkbxpcl;
        private System.Windows.Forms.CheckBox chkbxuan;
        private System.Windows.Forms.CheckBox chkbxservicesall;
        private System.Windows.Forms.Panel paneluser;
        private System.Windows.Forms.CheckBox chkbxcallingparty;
        private System.Windows.Forms.TextBox txtbxcallingparty;
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.Label lblenddate;
        private System.Windows.Forms.Label lbluserinput;
        private System.Windows.Forms.Panel pnldisplayselection;
        private System.Windows.Forms.CheckBox chkbxshp;
        private System.Windows.Forms.CheckBox chkbxseltp;
        private System.Windows.Forms.CheckBox chkbxselcp;
        private System.Windows.Forms.CheckBox chkbxsdt;
        private System.Windows.Forms.CheckBox chkbxccls;
        private System.Windows.Forms.CheckBox chkbxccst;
        private System.Windows.Forms.CheckBox chkbxdur;
        private System.Windows.Forms.CheckBox chkbxedt;
        private System.Windows.Forms.CheckBox chkbxfcnt;
        private System.Windows.Forms.CheckBox chkbxssno;
        private System.Windows.Forms.CheckBox chkbxuid;
        private System.Windows.Forms.CheckBox chkbxscpt;
        private System.Windows.Forms.CheckBox chkbxecc;
        private System.Windows.Forms.CheckBox chkbxbcc;
        private System.Windows.Forms.MenuStrip menustripmain;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInputsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label lbldiaplyset;
        private System.Windows.Forms.ToolStripMenuItem allFieldsToolStripMenuItem;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.ComboBox cmbbxdsplsel;
        private System.Windows.Forms.TextBox txtbxcardno;
        private System.Windows.Forms.CheckBox chkbxcardno;
        private System.Windows.Forms.CheckBox chkbxselall;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusstrip;
        private System.Windows.Forms.DateTimePicker dateTimePickerend;
        private System.Windows.Forms.DateTimePicker dateTimePickerstart;
        private System.Windows.Forms.ComboBox cmbbxmonthsel;
        private System.Windows.Forms.ComboBox cmbBoxSummary;
        private System.Windows.Forms.Label lblSummaryof;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;


    }
}

