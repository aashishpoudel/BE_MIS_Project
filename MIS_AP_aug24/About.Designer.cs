namespace MIS
{
    partial class fclsabout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fclsabout));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.btnaboutok = new System.Windows.Forms.Button();
            this.lblmis = new System.Windows.Forms.Label();
            this.lblcredits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 73);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(118, 24);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(154, 20);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Intelligent Network \r\n";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // btnaboutok
            // 
            this.btnaboutok.Location = new System.Drawing.Point(103, 231);
            this.btnaboutok.Name = "btnaboutok";
            this.btnaboutok.Size = new System.Drawing.Size(75, 23);
            this.btnaboutok.TabIndex = 2;
            this.btnaboutok.Text = "Done";
            this.btnaboutok.UseVisualStyleBackColor = true;
            this.btnaboutok.Click += new System.EventHandler(this.btnaboutok_Click);
            // 
            // lblmis
            // 
            this.lblmis.AutoSize = true;
            this.lblmis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmis.Location = new System.Drawing.Point(118, 47);
            this.lblmis.Name = "lblmis";
            this.lblmis.Size = new System.Drawing.Size(166, 28);
            this.lblmis.TabIndex = 3;
            this.lblmis.Text = "Management Information System \r\nReporting Software\r\n";
            // 
            // lblcredits
            // 
            this.lblcredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcredits.Location = new System.Drawing.Point(15, 104);
            this.lblcredits.Name = "lblcredits";
            this.lblcredits.Size = new System.Drawing.Size(256, 118);
            this.lblcredits.TabIndex = 4;
            this.lblcredits.Text = resources.GetString("lblcredits.Text");
            this.lblcredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fclsabout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lblcredits);
            this.Controls.Add(this.lblmis);
            this.Controls.Add(this.btnaboutok);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fclsabout";
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fclsabout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnaboutok;
        private System.Windows.Forms.Label lblmis;
        private System.Windows.Forms.Label lblcredits;
    }
}