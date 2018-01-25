namespace MIS
{
    partial class connection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxHostname = new System.Windows.Forms.TextBox();
            this.txtBxUsename = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxPortNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxdatabase = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hostname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // txtBxHostname
            // 
            this.txtBxHostname.Location = new System.Drawing.Point(94, 17);
            this.txtBxHostname.Name = "txtBxHostname";
            this.txtBxHostname.Size = new System.Drawing.Size(100, 20);
            this.txtBxHostname.TabIndex = 0;
            this.txtBxHostname.Text = "localhost";
            this.txtBxHostname.TextChanged += new System.EventHandler(this.txtBxHostname_TextChanged);
            // 
            // txtBxUsename
            // 
            this.txtBxUsename.Location = new System.Drawing.Point(285, 14);
            this.txtBxUsename.Name = "txtBxUsename";
            this.txtBxUsename.Size = new System.Drawing.Size(100, 20);
            this.txtBxUsename.TabIndex = 2;
            this.txtBxUsename.Text = "root";
            this.txtBxUsename.TextChanged += new System.EventHandler(this.txtBxUsename_TextChanged);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(285, 39);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBxPassword.TabIndex = 3;
            this.txtBxPassword.TextChanged += new System.EventHandler(this.txtBxPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port no:";
            // 
            // txtBxPortNo
            // 
            this.txtBxPortNo.Location = new System.Drawing.Point(94, 43);
            this.txtBxPortNo.Name = "txtBxPortNo";
            this.txtBxPortNo.Size = new System.Drawing.Size(100, 20);
            this.txtBxPortNo.TabIndex = 1;
            this.txtBxPortNo.Text = "3306";
            this.txtBxPortNo.TextChanged += new System.EventHandler(this.txtBxPortNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Database:";
            // 
            // txtBxdatabase
            // 
            this.txtBxdatabase.Location = new System.Drawing.Point(94, 71);
            this.txtBxdatabase.Name = "txtBxdatabase";
            this.txtBxdatabase.Size = new System.Drawing.Size(100, 20);
            this.txtBxdatabase.TabIndex = 4;
            this.txtBxdatabase.Text = "intel_network";
            this.txtBxdatabase.TextChanged += new System.EventHandler(this.txtBxdatabase_TextChanged);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(224, 97);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(307, 97);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // connection
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(398, 132);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtBxdatabase);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsename);
            this.Controls.Add(this.txtBxPortNo);
            this.Controls.Add(this.txtBxHostname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxHostname;
        private System.Windows.Forms.TextBox txtBxUsename;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxPortNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxdatabase;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
    }
}