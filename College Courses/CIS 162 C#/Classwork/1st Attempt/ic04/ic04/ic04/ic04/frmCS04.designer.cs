namespace ic04
{
    partial class frmCS04
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
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblExtendedWarranty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radThreeYears = new System.Windows.Forms.RadioButton();
            this.radOneYear = new System.Windows.Forms.RadioButton();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.lblTotalTaxAndLicensing = new System.Windows.Forms.Label();
            this.lblTotalOptions = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLicensing = new System.Windows.Forms.Label();
            this.lblStateAndLocalTaxes = new System.Windows.Forms.Label();
            this.lblFederalTaxes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkWheels = new System.Windows.Forms.CheckBox();
            this.chkPaint = new System.Windows.Forms.CheckBox();
            this.chkAC = new System.Windows.Forms.CheckBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnFinancing = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joes Auto Emporium";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(92, 51);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(281, 51);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(32, 20);
            this.txtYear.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Base Price";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(306, 15);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(64, 20);
            this.txtBasePrice.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblExtendedWarranty);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.lblTotalTaxAndLicensing);
            this.groupBox2.Controls.Add(this.lblTotalOptions);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtBasePrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 379);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice";
            // 
            // lblExtendedWarranty
            // 
            this.lblExtendedWarranty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExtendedWarranty.Location = new System.Drawing.Point(321, 212);
            this.lblExtendedWarranty.Name = "lblExtendedWarranty";
            this.lblExtendedWarranty.Size = new System.Drawing.Size(67, 23);
            this.lblExtendedWarranty.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Extended Warranty";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radThreeYears);
            this.groupBox4.Controls.Add(this.radOneYear);
            this.groupBox4.Controls.Add(this.radNone);
            this.groupBox4.Location = new System.Drawing.Point(6, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 83);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extended Warranty";
            // 
            // radThreeYears
            // 
            this.radThreeYears.AutoSize = true;
            this.radThreeYears.Location = new System.Drawing.Point(13, 61);
            this.radThreeYears.Name = "radThreeYears";
            this.radThreeYears.Size = new System.Drawing.Size(61, 17);
            this.radThreeYears.TabIndex = 2;
            this.radThreeYears.Text = "3 Years";
            this.radThreeYears.UseVisualStyleBackColor = true;
            // 
            // radOneYear
            // 
            this.radOneYear.AutoSize = true;
            this.radOneYear.Location = new System.Drawing.Point(13, 38);
            this.radOneYear.Name = "radOneYear";
            this.radOneYear.Size = new System.Drawing.Size(59, 17);
            this.radOneYear.TabIndex = 1;
            this.radOneYear.Text = "1 Year ";
            this.radOneYear.UseVisualStyleBackColor = true;
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Checked = true;
            this.radNone.Location = new System.Drawing.Point(13, 15);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(51, 17);
            this.radNone.TabIndex = 0;
            this.radNone.TabStop = true;
            this.radNone.Text = "None";
            this.radNone.UseVisualStyleBackColor = true;
            // 
            // lblTotalTaxAndLicensing
            // 
            this.lblTotalTaxAndLicensing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalTaxAndLicensing.Location = new System.Drawing.Point(303, 346);
            this.lblTotalTaxAndLicensing.Name = "lblTotalTaxAndLicensing";
            this.lblTotalTaxAndLicensing.Size = new System.Drawing.Size(67, 23);
            this.lblTotalTaxAndLicensing.TabIndex = 15;
            // 
            // lblTotalOptions
            // 
            this.lblTotalOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalOptions.Location = new System.Drawing.Point(321, 104);
            this.lblTotalOptions.Name = "lblTotalOptions";
            this.lblTotalOptions.Size = new System.Drawing.Size(67, 23);
            this.lblTotalOptions.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total Tax && Licensing";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLicensing);
            this.groupBox3.Controls.Add(this.lblStateAndLocalTaxes);
            this.groupBox3.Controls.Add(this.lblFederalTaxes);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(10, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 96);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taxes && Licenses";
            // 
            // lblLicensing
            // 
            this.lblLicensing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLicensing.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicensing.Location = new System.Drawing.Point(120, 68);
            this.lblLicensing.Name = "lblLicensing";
            this.lblLicensing.Size = new System.Drawing.Size(50, 15);
            this.lblLicensing.TabIndex = 17;
            // 
            // lblStateAndLocalTaxes
            // 
            this.lblStateAndLocalTaxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStateAndLocalTaxes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateAndLocalTaxes.Location = new System.Drawing.Point(120, 21);
            this.lblStateAndLocalTaxes.Name = "lblStateAndLocalTaxes";
            this.lblStateAndLocalTaxes.Size = new System.Drawing.Size(50, 15);
            this.lblStateAndLocalTaxes.TabIndex = 16;
            // 
            // lblFederalTaxes
            // 
            this.lblFederalTaxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFederalTaxes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFederalTaxes.Location = new System.Drawing.Point(120, 44);
            this.lblFederalTaxes.Name = "lblFederalTaxes";
            this.lblFederalTaxes.Size = new System.Drawing.Size(50, 15);
            this.lblFederalTaxes.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Licensing";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Federal Taxes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "State && Local Taxes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkWheels);
            this.groupBox1.Controls.Add(this.chkPaint);
            this.groupBox1.Controls.Add(this.chkAC);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 82);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkWheels
            // 
            this.chkWheels.AutoSize = true;
            this.chkWheels.Location = new System.Drawing.Point(20, 55);
            this.chkWheels.Name = "chkWheels";
            this.chkWheels.Size = new System.Drawing.Size(62, 17);
            this.chkWheels.TabIndex = 10;
            this.chkWheels.Text = "Wheels";
            this.chkWheels.UseVisualStyleBackColor = true;
            // 
            // chkPaint
            // 
            this.chkPaint.AutoSize = true;
            this.chkPaint.Location = new System.Drawing.Point(20, 37);
            this.chkPaint.Name = "chkPaint";
            this.chkPaint.Size = new System.Drawing.Size(50, 17);
            this.chkPaint.TabIndex = 9;
            this.chkPaint.Text = "Paint";
            this.chkPaint.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            this.chkAC.AutoSize = true;
            this.chkAC.Location = new System.Drawing.Point(20, 19);
            this.chkAC.Name = "chkAC";
            this.chkAC.Size = new System.Drawing.Size(45, 17);
            this.chkAC.TabIndex = 8;
            this.chkAC.Text = "A/C";
            this.chkAC.UseVisualStyleBackColor = true;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(315, 480);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(95, 23);
            this.lblGrandTotal.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(221, 484);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Grand Total";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(455, 157);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(0, 13);
            this.lblSummary.TabIndex = 18;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(478, 44);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnFinancing
            // 
            this.btnFinancing.Location = new System.Drawing.Point(482, 91);
            this.btnFinancing.Name = "btnFinancing";
            this.btnFinancing.Size = new System.Drawing.Size(70, 24);
            this.btnFinancing.TabIndex = 20;
            this.btnFinancing.Text = "Financing";
            this.btnFinancing.UseVisualStyleBackColor = true;
            this.btnFinancing.Click += new System.EventHandler(this.btnFinancing_Click);
            // 
            // frmCS04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 544);
            this.Controls.Add(this.btnFinancing);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCS04";
            this.Text = "ic04 - Corker";
            this.Load += new System.EventHandler(this.frmCS03_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalTaxAndLicensing;
        private System.Windows.Forms.Label lblTotalOptions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkWheels;
        private System.Windows.Forms.CheckBox chkPaint;
        private System.Windows.Forms.CheckBox chkAC;
        private System.Windows.Forms.RadioButton radThreeYears;
        private System.Windows.Forms.RadioButton radOneYear;
        private System.Windows.Forms.RadioButton radNone;
        private System.Windows.Forms.Label lblExtendedWarranty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLicensing;
        private System.Windows.Forms.Label lblStateAndLocalTaxes;
        private System.Windows.Forms.Label lblFederalTaxes;
        private System.Windows.Forms.Button btnFinancing;
    }
}

