namespace CS04_AlexKolar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWagesSalariesTips = new System.Windows.Forms.TextBox();
            this.chkBornBefore1946 = new System.Windows.Forms.CheckBox();
            this.chkBlind = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfDeductions = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalDeductions = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTaxesDue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGrossIncome = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.txtFederalIncomeTaxWithheld = new System.Windows.Forms.TextBox();
            this.txtFirstTimeHomeBuyer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(76, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(236, 32);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalDeductions);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblNumberOfDeductions);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkBlind);
            this.groupBox2.Controls.Add(this.chkBornBefore1946);
            this.groupBox2.Location = new System.Drawing.Point(32, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deductions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wages, Salaries, Tips";
            // 
            // txtWagesSalariesTips
            // 
            this.txtWagesSalariesTips.Location = new System.Drawing.Point(476, 110);
            this.txtWagesSalariesTips.Name = "txtWagesSalariesTips";
            this.txtWagesSalariesTips.Size = new System.Drawing.Size(100, 20);
            this.txtWagesSalariesTips.TabIndex = 3;
            // 
            // chkBornBefore1946
            // 
            this.chkBornBefore1946.AutoSize = true;
            this.chkBornBefore1946.Location = new System.Drawing.Point(38, 31);
            this.chkBornBefore1946.Name = "chkBornBefore1946";
            this.chkBornBefore1946.Size = new System.Drawing.Size(155, 17);
            this.chkBornBefore1946.TabIndex = 0;
            this.chkBornBefore1946.Text = "You were born before 1946";
            this.chkBornBefore1946.UseVisualStyleBackColor = true;
            // 
            // chkBlind
            // 
            this.chkBlind.AutoSize = true;
            this.chkBlind.Location = new System.Drawing.Point(38, 54);
            this.chkBlind.Name = "chkBlind";
            this.chkBlind.Size = new System.Drawing.Size(89, 17);
            this.chkBlind.TabIndex = 0;
            this.chkBlind.Text = "You are Blind";
            this.chkBlind.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of Deductions:";
            // 
            // lblNumberOfDeductions
            // 
            this.lblNumberOfDeductions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfDeductions.Location = new System.Drawing.Point(301, 47);
            this.lblNumberOfDeductions.Name = "lblNumberOfDeductions";
            this.lblNumberOfDeductions.Size = new System.Drawing.Size(35, 28);
            this.lblNumberOfDeductions.TabIndex = 2;
            this.lblNumberOfDeductions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Deductions (Number of Deductions x $3500):";
            // 
            // lblTotalDeductions
            // 
            this.lblTotalDeductions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeductions.Location = new System.Drawing.Point(275, 96);
            this.lblTotalDeductions.Name = "lblTotalDeductions";
            this.lblTotalDeductions.Size = new System.Drawing.Size(121, 31);
            this.lblTotalDeductions.TabIndex = 4;
            this.lblTotalDeductions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTaxesDue);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblTaxRate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(34, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 85);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taxes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tax Rate (Based on Salary):";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxRate.Location = new System.Drawing.Point(182, 21);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(42, 23);
            this.lblTaxRate.TabIndex = 1;
            this.lblTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Taxes Due (Tax Rate x Gross Income):";
            // 
            // lblTaxesDue
            // 
            this.lblTaxesDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxesDue.Location = new System.Drawing.Point(235, 48);
            this.lblTaxesDue.Name = "lblTaxesDue";
            this.lblTaxesDue.Size = new System.Drawing.Size(117, 27);
            this.lblTaxesDue.TabIndex = 3;
            this.lblTaxesDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gross Income:";
            // 
            // lblGrossIncome
            // 
            this.lblGrossIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossIncome.Location = new System.Drawing.Point(411, 301);
            this.lblGrossIncome.Name = "lblGrossIncome";
            this.lblGrossIncome.Size = new System.Drawing.Size(121, 27);
            this.lblGrossIncome.TabIndex = 6;
            this.lblGrossIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFirstTimeHomeBuyer);
            this.groupBox4.Controls.Add(this.txtFederalIncomeTaxWithheld);
            this.groupBox4.Controls.Add(this.lblTotalPayments);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(35, 425);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 108);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payments";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Federal Income Tax Withheld:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "First Time Home Buyer:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Total Payments:";
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPayments.Location = new System.Drawing.Point(291, 72);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(99, 26);
            this.lblTotalPayments.TabIndex = 2;
            this.lblTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFederalIncomeTaxWithheld
            // 
            this.txtFederalIncomeTaxWithheld.Location = new System.Drawing.Point(187, 18);
            this.txtFederalIncomeTaxWithheld.Name = "txtFederalIncomeTaxWithheld";
            this.txtFederalIncomeTaxWithheld.Size = new System.Drawing.Size(100, 20);
            this.txtFederalIncomeTaxWithheld.TabIndex = 3;
            // 
            // txtFirstTimeHomeBuyer
            // 
            this.txtFirstTimeHomeBuyer.Location = new System.Drawing.Point(187, 48);
            this.txtFirstTimeHomeBuyer.Name = "txtFirstTimeHomeBuyer";
            this.txtFirstTimeHomeBuyer.Size = new System.Drawing.Size(100, 20);
            this.txtFirstTimeHomeBuyer.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(193, 549);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Total Amount Due (Taxes Due - Payments):";
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDue.Location = new System.Drawing.Point(408, 543);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(124, 25);
            this.lblTotalDue.TabIndex = 9;
            this.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(481, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(126, 42);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(507, 171);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(50, 13);
            this.lblSummary.TabIndex = 11;
            this.lblSummary.Text = "Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 593);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblGrossIncome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtWagesSalariesTips);
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalDeductions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumberOfDeductions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBlind;
        private System.Windows.Forms.CheckBox chkBornBefore1946;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWagesSalariesTips;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTaxesDue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGrossIncome;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFirstTimeHomeBuyer;
        private System.Windows.Forms.TextBox txtFederalIncomeTaxWithheld;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSummary;
    }
}

