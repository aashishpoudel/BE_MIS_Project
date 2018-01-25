namespace MIS
{
    partial class SummReport
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotCost = new System.Windows.Forms.TextBox();
            this.txtTotRec = new System.Windows.Forms.TextBox();
            this.btnCloseSummary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.txtBxCC = new System.Windows.Forms.TextBox();
            this.pnlChargeClass = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnGridView = new System.Windows.Forms.Button();
            this.pnlChargeClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Call Summary Report for Charge Class";
            // 
            // txtTotDuration
            // 
            this.txtTotDuration.Location = new System.Drawing.Point(110, 148);
            this.txtTotDuration.Name = "txtTotDuration";
            this.txtTotDuration.Size = new System.Drawing.Size(112, 20);
            this.txtTotDuration.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total Call Duration";
            // 
            // txtTotCost
            // 
            this.txtTotCost.Location = new System.Drawing.Point(110, 113);
            this.txtTotCost.Name = "txtTotCost";
            this.txtTotCost.Size = new System.Drawing.Size(112, 20);
            this.txtTotCost.TabIndex = 20;
            // 
            // txtTotRec
            // 
            this.txtTotRec.Location = new System.Drawing.Point(110, 80);
            this.txtTotRec.Name = "txtTotRec";
            this.txtTotRec.Size = new System.Drawing.Size(112, 20);
            this.txtTotRec.TabIndex = 19;
            // 
            // btnCloseSummary
            // 
            this.btnCloseSummary.Location = new System.Drawing.Point(420, 210);
            this.btnCloseSummary.Name = "btnCloseSummary";
            this.btnCloseSummary.Size = new System.Drawing.Size(57, 23);
            this.btnCloseSummary.TabIndex = 18;
            this.btnCloseSummary.Text = "Close";
            this.btnCloseSummary.UseVisualStyleBackColor = true;
            this.btnCloseSummary.Click += new System.EventHandler(this.btnCloseSummary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total Call Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total Records";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "ShowExcelReport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(411, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 27);
            this.button3.TabIndex = 39;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 27);
            this.button2.TabIndex = 38;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 27);
            this.button4.TabIndex = 37;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Location = new System.Drawing.Point(291, 130);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(32, 27);
            this.btnMoveFirst.TabIndex = 35;
            this.btnMoveFirst.Text = "<<";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // txtBxCC
            // 
            this.txtBxCC.Location = new System.Drawing.Point(126, 29);
            this.txtBxCC.Name = "txtBxCC";
            this.txtBxCC.Size = new System.Drawing.Size(34, 20);
            this.txtBxCC.TabIndex = 34;
            this.txtBxCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxCC.TextChanged += new System.EventHandler(this.txtBxCC_TextChanged);
            // 
            // pnlChargeClass
            // 
            this.pnlChargeClass.Controls.Add(this.radioButton2);
            this.pnlChargeClass.Controls.Add(this.radioButton1);
            this.pnlChargeClass.Controls.Add(this.txtBxCC);
            this.pnlChargeClass.Location = new System.Drawing.Point(266, 68);
            this.pnlChargeClass.Name = "pnlChargeClass";
            this.pnlChargeClass.Size = new System.Drawing.Size(213, 56);
            this.pnlChargeClass.TabIndex = 40;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Charge Class";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 17);
            this.radioButton1.TabIndex = 37;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnGridView
            // 
            this.btnGridView.Location = new System.Drawing.Point(214, 210);
            this.btnGridView.Name = "btnGridView";
            this.btnGridView.Size = new System.Drawing.Size(87, 23);
            this.btnGridView.TabIndex = 41;
            this.btnGridView.Text = "Grid View";
            this.btnGridView.UseVisualStyleBackColor = true;
            this.btnGridView.Click += new System.EventHandler(this.btnGridView_Click);
            // 
            // SummReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 242);
            this.Controls.Add(this.btnGridView);
            this.Controls.Add(this.pnlChargeClass);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMoveFirst);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotCost);
            this.Controls.Add(this.txtTotRec);
            this.Controls.Add(this.btnCloseSummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SummReport";
            this.Text = "SummReport";
            this.Load += new System.EventHandler(this.SummReport_Load);
            this.pnlChargeClass.ResumeLayout(false);
            this.pnlChargeClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTotDuration;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTotCost;
        public System.Windows.Forms.TextBox txtTotRec;
        private System.Windows.Forms.Button btnCloseSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMoveFirst;
        public System.Windows.Forms.TextBox txtBxCC;
        private System.Windows.Forms.Panel pnlChargeClass;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnGridView;
    }
}