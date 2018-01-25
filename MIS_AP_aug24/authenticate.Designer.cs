namespace MIS
{
    partial class authenticate
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
            this.tabauth = new System.Windows.Forms.TabControl();
            this.tablogin = new System.Windows.Forms.TabPage();
            this.btnok = new System.Windows.Forms.Button();
            this.btnauthquit = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtbxpassword = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtbxusername = new System.Windows.Forms.TextBox();
            this.tabchngpass = new System.Windows.Forms.TabPage();
            this.btnCancelnp = new System.Windows.Forms.Button();
            this.btnOKnp = new System.Windows.Forms.Button();
            this.txtBxconfirm = new System.Windows.Forms.TextBox();
            this.lblconfirm = new System.Windows.Forms.Label();
            this.txtBxnewpass = new System.Windows.Forms.TextBox();
            this.lblnewpass = new System.Windows.Forms.Label();
            this.txtBxoldpass = new System.Windows.Forms.TextBox();
            this.lbloldpass = new System.Windows.Forms.Label();
            this.txtBxnewuser = new System.Windows.Forms.TextBox();
            this.lblnewuser = new System.Windows.Forms.Label();
            this.tabauth.SuspendLayout();
            this.tablogin.SuspendLayout();
            this.tabchngpass.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabauth
            // 
            this.tabauth.Controls.Add(this.tablogin);
            this.tabauth.Controls.Add(this.tabchngpass);
            this.tabauth.HotTrack = true;
            this.tabauth.Location = new System.Drawing.Point(22, 12);
            this.tabauth.Name = "tabauth";
            this.tabauth.SelectedIndex = 0;
            this.tabauth.Size = new System.Drawing.Size(260, 181);
            this.tabauth.TabIndex = 0;
            // 
            // tablogin
            // 
            this.tablogin.Controls.Add(this.btnok);
            this.tablogin.Controls.Add(this.btnauthquit);
            this.tablogin.Controls.Add(this.lblpassword);
            this.tablogin.Controls.Add(this.txtbxpassword);
            this.tablogin.Controls.Add(this.lbluser);
            this.tablogin.Controls.Add(this.txtbxusername);
            this.tablogin.Location = new System.Drawing.Point(4, 22);
            this.tablogin.Name = "tablogin";
            this.tablogin.Padding = new System.Windows.Forms.Padding(3);
            this.tablogin.Size = new System.Drawing.Size(252, 155);
            this.tablogin.TabIndex = 0;
            this.tablogin.Text = "Login";
            this.tablogin.UseVisualStyleBackColor = true;
            this.tablogin.Click += new System.EventHandler(this.tablogin_Click);
            // 
            // btnok
            // 
            this.btnok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnok.Location = new System.Drawing.Point(22, 111);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 3;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnauthquit
            // 
            this.btnauthquit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnauthquit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnauthquit.Location = new System.Drawing.Point(145, 111);
            this.btnauthquit.Name = "btnauthquit";
            this.btnauthquit.Size = new System.Drawing.Size(75, 23);
            this.btnauthquit.TabIndex = 4;
            this.btnauthquit.Text = "Cancel";
            this.btnauthquit.UseVisualStyleBackColor = true;
            this.btnauthquit.Click += new System.EventHandler(this.btnauthquit_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblpassword.Location = new System.Drawing.Point(21, 72);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 9;
            this.lblpassword.Text = "Password";
            // 
            // txtbxpassword
            // 
            this.txtbxpassword.Location = new System.Drawing.Point(82, 71);
            this.txtbxpassword.Name = "txtbxpassword";
            this.txtbxpassword.PasswordChar = '*';
            this.txtbxpassword.Size = new System.Drawing.Size(138, 20);
            this.txtbxpassword.TabIndex = 2;
            // 
            // lbluser
            // 
            this.lbluser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbluser.Location = new System.Drawing.Point(21, 30);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(55, 13);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "Username";
            // 
            // txtbxusername
            // 
            this.txtbxusername.Location = new System.Drawing.Point(82, 29);
            this.txtbxusername.Name = "txtbxusername";
            this.txtbxusername.Size = new System.Drawing.Size(138, 20);
            this.txtbxusername.TabIndex = 1;
            // 
            // tabchngpass
            // 
            this.tabchngpass.Controls.Add(this.btnCancelnp);
            this.tabchngpass.Controls.Add(this.btnOKnp);
            this.tabchngpass.Controls.Add(this.txtBxconfirm);
            this.tabchngpass.Controls.Add(this.lblconfirm);
            this.tabchngpass.Controls.Add(this.txtBxnewpass);
            this.tabchngpass.Controls.Add(this.lblnewpass);
            this.tabchngpass.Controls.Add(this.txtBxoldpass);
            this.tabchngpass.Controls.Add(this.lbloldpass);
            this.tabchngpass.Controls.Add(this.txtBxnewuser);
            this.tabchngpass.Controls.Add(this.lblnewuser);
            this.tabchngpass.Location = new System.Drawing.Point(4, 22);
            this.tabchngpass.Name = "tabchngpass";
            this.tabchngpass.Padding = new System.Windows.Forms.Padding(3);
            this.tabchngpass.Size = new System.Drawing.Size(252, 155);
            this.tabchngpass.TabIndex = 1;
            this.tabchngpass.Text = "Change Password";
            this.tabchngpass.UseVisualStyleBackColor = true;
            this.tabchngpass.Click += new System.EventHandler(this.tabchngpass_Click);
            // 
            // btnCancelnp
            // 
            this.btnCancelnp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelnp.Location = new System.Drawing.Point(143, 124);
            this.btnCancelnp.Name = "btnCancelnp";
            this.btnCancelnp.Size = new System.Drawing.Size(75, 23);
            this.btnCancelnp.TabIndex = 9;
            this.btnCancelnp.Text = "Cancel";
            this.btnCancelnp.UseVisualStyleBackColor = true;
            this.btnCancelnp.Click += new System.EventHandler(this.btnCancelnp_Click);
            // 
            // btnOKnp
            // 
            this.btnOKnp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOKnp.Location = new System.Drawing.Point(18, 124);
            this.btnOKnp.Name = "btnOKnp";
            this.btnOKnp.Size = new System.Drawing.Size(75, 23);
            this.btnOKnp.TabIndex = 8;
            this.btnOKnp.Text = "OK";
            this.btnOKnp.UseVisualStyleBackColor = true;
            this.btnOKnp.Click += new System.EventHandler(this.btnOKnp_Click);
            // 
            // txtBxconfirm
            // 
            this.txtBxconfirm.Location = new System.Drawing.Point(111, 95);
            this.txtBxconfirm.Name = "txtBxconfirm";
            this.txtBxconfirm.PasswordChar = '*';
            this.txtBxconfirm.Size = new System.Drawing.Size(135, 20);
            this.txtBxconfirm.TabIndex = 7;
            // 
            // lblconfirm
            // 
            this.lblconfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblconfirm.Location = new System.Drawing.Point(6, 97);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(99, 18);
            this.lblconfirm.TabIndex = 6;
            this.lblconfirm.Text = "Retype Password";
            // 
            // txtBxnewpass
            // 
            this.txtBxnewpass.Location = new System.Drawing.Point(111, 70);
            this.txtBxnewpass.Name = "txtBxnewpass";
            this.txtBxnewpass.PasswordChar = '*';
            this.txtBxnewpass.Size = new System.Drawing.Size(135, 20);
            this.txtBxnewpass.TabIndex = 5;
            // 
            // lblnewpass
            // 
            this.lblnewpass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnewpass.Location = new System.Drawing.Point(6, 72);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(87, 18);
            this.lblnewpass.TabIndex = 4;
            this.lblnewpass.Text = "New Password";
            // 
            // txtBxoldpass
            // 
            this.txtBxoldpass.Location = new System.Drawing.Point(111, 43);
            this.txtBxoldpass.Name = "txtBxoldpass";
            this.txtBxoldpass.PasswordChar = '*';
            this.txtBxoldpass.Size = new System.Drawing.Size(135, 20);
            this.txtBxoldpass.TabIndex = 3;
            // 
            // lbloldpass
            // 
            this.lbloldpass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbloldpass.Location = new System.Drawing.Point(6, 45);
            this.lbloldpass.Name = "lbloldpass";
            this.lbloldpass.Size = new System.Drawing.Size(87, 18);
            this.lbloldpass.TabIndex = 2;
            this.lbloldpass.Text = "Old Password";
            // 
            // txtBxnewuser
            // 
            this.txtBxnewuser.Location = new System.Drawing.Point(111, 17);
            this.txtBxnewuser.Name = "txtBxnewuser";
            this.txtBxnewuser.Size = new System.Drawing.Size(135, 20);
            this.txtBxnewuser.TabIndex = 1;
            // 
            // lblnewuser
            // 
            this.lblnewuser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnewuser.Location = new System.Drawing.Point(6, 19);
            this.lblnewuser.Name = "lblnewuser";
            this.lblnewuser.Size = new System.Drawing.Size(58, 18);
            this.lblnewuser.TabIndex = 0;
            this.lblnewuser.Text = "Username";
            // 
            // authenticate
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnauthquit;
            this.ClientSize = new System.Drawing.Size(294, 205);
            this.Controls.Add(this.tabauth);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "authenticate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.authenticate_Load);
            this.tabauth.ResumeLayout(false);
            this.tablogin.ResumeLayout(false);
            this.tablogin.PerformLayout();
            this.tabchngpass.ResumeLayout(false);
            this.tabchngpass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabauth;
        private System.Windows.Forms.TabPage tablogin;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnauthquit;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtbxpassword;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtbxusername;
        private System.Windows.Forms.TabPage tabchngpass;
        private System.Windows.Forms.Label lbloldpass;
        private System.Windows.Forms.TextBox txtBxnewuser;
        private System.Windows.Forms.Label lblnewuser;
        private System.Windows.Forms.TextBox txtBxoldpass;
        private System.Windows.Forms.TextBox txtBxnewpass;
        private System.Windows.Forms.Label lblnewpass;
        private System.Windows.Forms.TextBox txtBxconfirm;
        private System.Windows.Forms.Label lblconfirm;
        private System.Windows.Forms.Button btnCancelnp;
        private System.Windows.Forms.Button btnOKnp;

    }
}