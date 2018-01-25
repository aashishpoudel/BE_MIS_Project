namespace MIS
{
    partial class RecordViewForm
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
            this.panelrecords = new System.Windows.Forms.Panel();
            this.DataGridRecords = new System.Windows.Forms.DataGrid();
            this.panelrecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panelrecords
            // 
            this.panelrecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelrecords.Controls.Add(this.DataGridRecords);
            this.panelrecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelrecords.Location = new System.Drawing.Point(0, 0);
            this.panelrecords.Name = "panelrecords";
            this.panelrecords.Padding = new System.Windows.Forms.Padding(10);
            this.panelrecords.Size = new System.Drawing.Size(529, 269);
            this.panelrecords.TabIndex = 1;
            this.panelrecords.Paint += new System.Windows.Forms.PaintEventHandler(this.panelrecords_Paint);
            // 
            // DataGridRecords
            // 
            this.DataGridRecords.DataMember = "";
            this.DataGridRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridRecords.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridRecords.Location = new System.Drawing.Point(10, 10);
            this.DataGridRecords.Name = "DataGridRecords";
            this.DataGridRecords.Size = new System.Drawing.Size(505, 245);
            this.DataGridRecords.TabIndex = 0;
            // 
            // RecordViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 269);
            this.Controls.Add(this.panelrecords);
            this.Name = "RecordViewForm";
            this.Text = "RecordViewForm";
            this.Load += new System.EventHandler(this.ChargeClassRecords_Load);
            this.panelrecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelrecords;
        public System.Windows.Forms.DataGrid DataGridRecords;
    }
}