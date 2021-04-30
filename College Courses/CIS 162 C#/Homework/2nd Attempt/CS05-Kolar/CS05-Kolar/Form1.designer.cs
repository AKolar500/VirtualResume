namespace CS05_Kolar
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalDeductions = new System.Windows.Forms.Label();
            this.lblDeductions = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBlind = new System.Windows.Forms.CheckBox();
            this.chkBeforeTime = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTaxesDue = new System.Windows.Forms.Label();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFederal = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lblFirstTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFirstTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtWages = new System.Windows.Forms.TextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnPayments = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLast);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(263, 33);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(80, 20);
            this.txtLast.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(76, 33);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(80, 20);
            this.txtFirst.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblTotalDeductions);
            this.groupBox2.Controls.Add(this.lblDeductions);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkBlind);
            this.groupBox2.Controls.Add(this.chkBeforeTime);
            this.groupBox2.Location = new System.Drawing.Point(26, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deductions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Deductions (Number of Deductions x $3500)";
            // 
            // lblTotalDeductions
            // 
            this.lblTotalDeductions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeductions.Location = new System.Drawing.Point(283, 82);
            this.lblTotalDeductions.Name = "lblTotalDeductions";
            this.lblTotalDeductions.Size = new System.Drawing.Size(73, 21);
            this.lblTotalDeductions.TabIndex = 4;
            this.lblTotalDeductions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeductions
            // 
            this.lblDeductions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeductions.Location = new System.Drawing.Point(283, 48);
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.Size = new System.Drawing.Size(33, 21);
            this.lblDeductions.TabIndex = 5;
            this.lblDeductions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Number of Deductions";
            // 
            // chkBlind
            // 
            this.chkBlind.AutoSize = true;
            this.chkBlind.Location = new System.Drawing.Point(24, 51);
            this.chkBlind.Name = "chkBlind";
            this.chkBlind.Size = new System.Drawing.Size(89, 17);
            this.chkBlind.TabIndex = 1;
            this.chkBlind.Text = "You are Blind";
            this.chkBlind.UseVisualStyleBackColor = true;
            // 
            // chkBeforeTime
            // 
            this.chkBeforeTime.AutoSize = true;
            this.chkBeforeTime.Location = new System.Drawing.Point(24, 28);
            this.chkBeforeTime.Name = "chkBeforeTime";
            this.chkBeforeTime.Size = new System.Drawing.Size(155, 17);
            this.chkBeforeTime.TabIndex = 0;
            this.chkBeforeTime.Text = "You were born before 1946";
            this.chkBeforeTime.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wages, Salaries, Tips";
            // 
            // lblGross
            // 
            this.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGross.Location = new System.Drawing.Point(375, 291);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(73, 21);
            this.lblGross.TabIndex = 7;
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gross Income (wages - Deductions)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTaxesDue);
            this.groupBox3.Controls.Add(this.lblTaxRate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(28, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 97);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taxes";
            // 
            // lblTaxesDue
            // 
            this.lblTaxesDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxesDue.Location = new System.Drawing.Point(227, 51);
            this.lblTaxesDue.Name = "lblTaxesDue";
            this.lblTaxesDue.Size = new System.Drawing.Size(73, 21);
            this.lblTaxesDue.TabIndex = 8;
            this.lblTaxesDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxRate.Location = new System.Drawing.Point(190, 23);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(35, 21);
            this.lblTaxRate.TabIndex = 7;
            this.lblTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Taxes Due (Tax Rate x Gross Income)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tax Rate (based on Salary)";
            // 
            // txtFederal
            // 
            this.txtFederal.Location = new System.Drawing.Point(174, 19);
            this.txtFederal.Name = "txtFederal";
            this.txtFederal.Size = new System.Drawing.Size(80, 20);
            this.txtFederal.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPayments);
            this.groupBox4.Controls.Add(this.lblFirstTime);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtFirstTime);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtFederal);
            this.groupBox4.Location = new System.Drawing.Point(30, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 121);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payments";
            // 
            // lblPayments
            // 
            this.lblPayments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayments.Location = new System.Drawing.Point(243, 84);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(73, 21);
            this.lblPayments.TabIndex = 10;
            this.lblPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstTime
            // 
            this.lblFirstTime.AutoSize = true;
            this.lblFirstTime.Location = new System.Drawing.Point(22, 53);
            this.lblFirstTime.Name = "lblFirstTime";
            this.lblFirstTime.Size = new System.Drawing.Size(113, 13);
            this.lblFirstTime.TabIndex = 7;
            this.lblFirstTime.Text = "First Time Home Buyer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Total Payments";
            // 
            // txtFirstTime
            // 
            this.txtFirstTime.Location = new System.Drawing.Point(174, 50);
            this.txtFirstTime.Name = "txtFirstTime";
            this.txtFirstTime.Size = new System.Drawing.Size(80, 20);
            this.txtFirstTime.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Federal Income Tax Withheld";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 566);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total Amount Due (Taxes Due - Payments)";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrandTotal.Location = new System.Drawing.Point(375, 562);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(73, 21);
            this.lblGrandTotal.TabIndex = 10;
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(505, 40);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 46);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "OK";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtWages
            // 
            this.txtWages.Location = new System.Drawing.Point(375, 118);
            this.txtWages.Name = "txtWages";
            this.txtWages.Size = new System.Drawing.Size(80, 20);
            this.txtWages.TabIndex = 11;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(484, 173);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(50, 13);
            this.lblSummary.TabIndex = 13;
            this.lblSummary.Text = "Summary";
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(487, 111);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(125, 27);
            this.btnPayments.TabIndex = 14;
            this.btnPayments.Text = "Payment Options";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 627);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.txtWages);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalDeductions;
        private System.Windows.Forms.Label lblDeductions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkBlind;
        private System.Windows.Forms.CheckBox chkBeforeTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTaxesDue;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFederal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label lblFirstTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFirstTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtWages;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnPayments;
    }
}

