namespace ic12_Start
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
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHonorsType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkHonors = new System.Windows.Forms.CheckBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstTranscript = new System.Windows.Forms.ListBox();
            this.txtCreditHrs = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblTotalGPA = new System.Windows.Forms.Label();
            this.grpItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(357, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Points";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quarter GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "College Transcripts";
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.label2);
            this.grpItem.Controls.Add(this.cboHonorsType);
            this.grpItem.Controls.Add(this.label1);
            this.grpItem.Controls.Add(this.chkHonors);
            this.grpItem.Controls.Add(this.label13);
            this.grpItem.Controls.Add(this.txtGrade);
            this.grpItem.Controls.Add(this.txtClass);
            this.grpItem.Controls.Add(this.label12);
            this.grpItem.Controls.Add(this.label11);
            this.grpItem.Controls.Add(this.label7);
            this.grpItem.Controls.Add(this.lstTranscript);
            this.grpItem.Controls.Add(this.txtCreditHrs);
            this.grpItem.Controls.Add(this.btnAddItem);
            this.grpItem.Controls.Add(this.Label9);
            this.grpItem.Controls.Add(this.Label8);
            this.grpItem.Controls.Add(this.Label6);
            this.grpItem.Location = new System.Drawing.Point(40, 70);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(723, 262);
            this.grpItem.TabIndex = 9;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Classes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Honors Type";
            // 
            // cboHonorsType
            // 
            this.cboHonorsType.FormattingEnabled = true;
            this.cboHonorsType.Items.AddRange(new object[] {
            "Evil Genius",
            "Whiny Genius",
            "Obsessive Genius"});
            this.cboHonorsType.Location = new System.Drawing.Point(481, 55);
            this.cboHonorsType.Name = "cboHonorsType";
            this.cboHonorsType.Size = new System.Drawing.Size(121, 21);
            this.cboHonorsType.TabIndex = 14;
            this.cboHonorsType.Text = "Select Honors Type";
            this.cboHonorsType.Visible = false;
            //this.cboHonorsType.SelectedIndexChanged += new System.EventHandler(this.cboHonorsType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Honors";
            // 
            // chkHonors
            // 
            this.chkHonors.AutoSize = true;
            this.chkHonors.Location = new System.Drawing.Point(502, 32);
            this.chkHonors.Name = "chkHonors";
            this.chkHonors.Size = new System.Drawing.Size(60, 17);
            this.chkHonors.TabIndex = 12;
            this.chkHonors.Text = "Honors";
            this.chkHonors.UseVisualStyleBackColor = true;
            this.chkHonors.CheckedChanged += new System.EventHandler(this.chkHonors_CheckedChanged);
            // 
            // txtGrade
            // 
            this.txtGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrade.Location = new System.Drawing.Point(408, 28);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(48, 20);
            this.txtGrade.TabIndex = 4;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(49, 30);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(170, 20);
            this.txtClass.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Grade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Credit Hrs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Class";
            // 
            // lstTranscript
            // 
            this.lstTranscript.FormattingEnabled = true;
            this.lstTranscript.Location = new System.Drawing.Point(53, 153);
            this.lstTranscript.Name = "lstTranscript";
            this.lstTranscript.Size = new System.Drawing.Size(590, 95);
            this.lstTranscript.TabIndex = 9;
            this.lstTranscript.SelectedIndexChanged += new System.EventHandler(this.lstTranscript_SelectedIndexChanged);
            // 
            // txtCreditHrs
            // 
            this.txtCreditHrs.Location = new System.Drawing.Point(290, 28);
            this.txtCreditHrs.Name = "txtCreditHrs";
            this.txtCreditHrs.Size = new System.Drawing.Size(37, 20);
            this.txtCreditHrs.TabIndex = 2;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(635, 24);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(43, 30);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(349, 33);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(36, 13);
            this.Label9.TabIndex = 3;
            this.Label9.Text = "Grade";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(231, 33);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(53, 13);
            this.Label8.TabIndex = 1;
            this.Label8.Text = "Credit Hrs";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(16, 32);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(32, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Class";
            // 
            // lblTotalGPA
            // 
            this.lblTotalGPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalGPA.Location = new System.Drawing.Point(497, 335);
            this.lblTotalGPA.Name = "lblTotalGPA";
            this.lblTotalGPA.Size = new System.Drawing.Size(65, 23);
            this.lblTotalGPA.TabIndex = 11;
            this.lblTotalGPA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 362);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.lblTotalGPA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.GroupBox grpItem;
        internal System.Windows.Forms.TextBox txtGrade;
        internal System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstTranscript;
        internal System.Windows.Forms.TextBox txtCreditHrs;
        private System.Windows.Forms.Button btnAddItem;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblTotalGPA;
        private System.Windows.Forms.CheckBox chkHonors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHonorsType;
        private System.Windows.Forms.Label label2;
    }
}

