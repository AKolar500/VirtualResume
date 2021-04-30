namespace ic04_02062013
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalTaxAndLicensing = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalOptions = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLicensing = new System.Windows.Forms.TextBox();
            this.txtFederalTaxes = new System.Windows.Forms.TextBox();
            this.txtStateAndLocalTaxes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.chkAC = new System.Windows.Forms.CheckBox();
            this.chkPaint = new System.Windows.Forms.CheckBox();
            this.chkWheels = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.rad1Year = new System.Windows.Forms.RadioButton();
            this.rad3Years = new System.Windows.Forms.RadioButton();
            this.lblExtendedWarranty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joe\'s Auto Emporium";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(405, 107);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 26);
            this.txtModel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(656, 112);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 26);
            this.txtYear.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(875, 109);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 33);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblExtendedWarranty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.lblTotalTaxAndLicensing);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblTotalOptions);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtBasePrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(87, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 534);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // lblTotalTaxAndLicensing
            // 
            this.lblTotalTaxAndLicensing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalTaxAndLicensing.Location = new System.Drawing.Point(627, 497);
            this.lblTotalTaxAndLicensing.Name = "lblTotalTaxAndLicensing";
            this.lblTotalTaxAndLicensing.Size = new System.Drawing.Size(100, 20);
            this.lblTotalTaxAndLicensing.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(453, 497);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Total Tax && Licensing";
            // 
            // lblTotalOptions
            // 
            this.lblTotalOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalOptions.Location = new System.Drawing.Point(627, 211);
            this.lblTotalOptions.Name = "lblTotalOptions";
            this.lblTotalOptions.Size = new System.Drawing.Size(100, 20);
            this.lblTotalOptions.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(509, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Total Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLicensing);
            this.groupBox3.Controls.Add(this.txtFederalTaxes);
            this.groupBox3.Controls.Add(this.txtStateAndLocalTaxes);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(63, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 150);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tax && Licensing";
            // 
            // txtLicensing
            // 
            this.txtLicensing.Location = new System.Drawing.Point(153, 96);
            this.txtLicensing.Name = "txtLicensing";
            this.txtLicensing.ReadOnly = true;
            this.txtLicensing.Size = new System.Drawing.Size(62, 26);
            this.txtLicensing.TabIndex = 11;
            // 
            // txtFederalTaxes
            // 
            this.txtFederalTaxes.Location = new System.Drawing.Point(153, 63);
            this.txtFederalTaxes.Name = "txtFederalTaxes";
            this.txtFederalTaxes.ReadOnly = true;
            this.txtFederalTaxes.Size = new System.Drawing.Size(62, 26);
            this.txtFederalTaxes.TabIndex = 10;
            // 
            // txtStateAndLocalTaxes
            // 
            this.txtStateAndLocalTaxes.Location = new System.Drawing.Point(153, 28);
            this.txtStateAndLocalTaxes.Name = "txtStateAndLocalTaxes";
            this.txtStateAndLocalTaxes.ReadOnly = true;
            this.txtStateAndLocalTaxes.Size = new System.Drawing.Size(62, 26);
            this.txtStateAndLocalTaxes.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Licensing";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Federal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "State && Local";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(627, 37);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(100, 26);
            this.txtBasePrice.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Base Price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkWheels);
            this.groupBox2.Controls.Add(this.chkPaint);
            this.groupBox2.Controls.Add(this.chkAC);
            this.groupBox2.Location = new System.Drawing.Point(54, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 142);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrandTotal.Location = new System.Drawing.Point(714, 731);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(100, 20);
            this.lblGrandTotal.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(588, 731);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Grand Total";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(885, 195);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(0, 20);
            this.lblSummary.TabIndex = 10;
            // 
            // chkAC
            // 
            this.chkAC.AutoSize = true;
            this.chkAC.Location = new System.Drawing.Point(23, 26);
            this.chkAC.Name = "chkAC";
            this.chkAC.Size = new System.Drawing.Size(104, 24);
            this.chkAC.TabIndex = 0;
            this.chkAC.Text = "A/C (2000)";
            this.chkAC.UseVisualStyleBackColor = true;
            // 
            // chkPaint
            // 
            this.chkPaint.AutoSize = true;
            this.chkPaint.Location = new System.Drawing.Point(23, 56);
            this.chkPaint.Name = "chkPaint";
            this.chkPaint.Size = new System.Drawing.Size(114, 24);
            this.chkPaint.TabIndex = 1;
            this.chkPaint.Text = "Paint (1500)";
            this.chkPaint.UseVisualStyleBackColor = true;
            // 
            // chkWheels
            // 
            this.chkWheels.AutoSize = true;
            this.chkWheels.Location = new System.Drawing.Point(23, 86);
            this.chkWheels.Name = "chkWheels";
            this.chkWheels.Size = new System.Drawing.Size(131, 24);
            this.chkWheels.TabIndex = 2;
            this.chkWheels.Text = "Wheels (2500)";
            this.chkWheels.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rad3Years);
            this.groupBox4.Controls.Add(this.rad1Year);
            this.groupBox4.Controls.Add(this.radNone);
            this.groupBox4.Location = new System.Drawing.Point(54, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 101);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extended Warranty";
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Checked = true;
            this.radNone.Location = new System.Drawing.Point(23, 25);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(65, 24);
            this.radNone.TabIndex = 0;
            this.radNone.TabStop = true;
            this.radNone.Text = "None";
            this.radNone.UseVisualStyleBackColor = true;
            // 
            // rad1Year
            // 
            this.rad1Year.AutoSize = true;
            this.rad1Year.Location = new System.Drawing.Point(23, 47);
            this.rad1Year.Name = "rad1Year";
            this.rad1Year.Size = new System.Drawing.Size(120, 24);
            this.rad1Year.TabIndex = 1;
            this.rad1Year.Text = "1 year (3000)";
            this.rad1Year.UseVisualStyleBackColor = true;
            // 
            // rad3Years
            // 
            this.rad3Years.AutoSize = true;
            this.rad3Years.Location = new System.Drawing.Point(23, 73);
            this.rad3Years.Name = "rad3Years";
            this.rad3Years.Size = new System.Drawing.Size(132, 24);
            this.rad3Years.TabIndex = 2;
            this.rad3Years.Text = "3 Years (5000)";
            this.rad3Years.UseVisualStyleBackColor = true;
            // 
            // lblExtendedWarranty
            // 
            this.lblExtendedWarranty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExtendedWarranty.Location = new System.Drawing.Point(627, 332);
            this.lblExtendedWarranty.Name = "lblExtendedWarranty";
            this.lblExtendedWarranty.Size = new System.Drawing.Size(100, 20);
            this.lblExtendedWarranty.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Extended Warranty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 783);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalTaxAndLicensing;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalOptions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLicensing;
        private System.Windows.Forms.TextBox txtFederalTaxes;
        private System.Windows.Forms.TextBox txtStateAndLocalTaxes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.CheckBox chkWheels;
        private System.Windows.Forms.CheckBox chkPaint;
        private System.Windows.Forms.CheckBox chkAC;
        private System.Windows.Forms.Label lblExtendedWarranty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rad3Years;
        private System.Windows.Forms.RadioButton rad1Year;
        private System.Windows.Forms.RadioButton radNone;
    }
}

