namespace ic10_3_28_2012
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
            this.txtClass = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblTotalGPA = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstTranscript = new System.Windows.Forms.ListBox();
            this.txtCreditHrs = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.grpItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(49, 30);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(170, 20);
            this.txtClass.TabIndex = 0;
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
            // lblTotalGPA
            // 
            this.lblTotalGPA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalGPA.Location = new System.Drawing.Point(422, 300);
            this.lblTotalGPA.Name = "lblTotalGPA";
            this.lblTotalGPA.Size = new System.Drawing.Size(65, 23);
            this.lblTotalGPA.TabIndex = 11;
            this.lblTotalGPA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrade
            // 
            this.txtGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrade.Location = new System.Drawing.Point(408, 28);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(48, 20);
            this.txtGrade.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quarter GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "College Transcripts";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(502, 24);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(43, 30);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Points";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Grade";
            // 
            // grpItem
            // 
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
            this.grpItem.Location = new System.Drawing.Point(57, 83);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(568, 199);
            this.grpItem.TabIndex = 9;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Classes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Credit Hrs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Class";
            // 
            // lstTranscript
            // 
            this.lstTranscript.FormattingEnabled = true;
            this.lstTranscript.Location = new System.Drawing.Point(31, 93);
            this.lstTranscript.Name = "lstTranscript";
            this.lstTranscript.Size = new System.Drawing.Size(399, 95);
            this.lstTranscript.TabIndex = 9;
            // 
            // txtCreditHrs
            // 
            this.txtCreditHrs.Location = new System.Drawing.Point(290, 28);
            this.txtCreditHrs.Name = "txtCreditHrs";
            this.txtCreditHrs.Size = new System.Drawing.Size(37, 20);
            this.txtCreditHrs.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 343);
            this.Controls.Add(this.lblTotalGPA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtClass;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label lblTotalGPA;
        internal System.Windows.Forms.TextBox txtGrade;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstTranscript;
        internal System.Windows.Forms.TextBox txtCreditHrs;
        internal System.Windows.Forms.Label Label6;
    }
}

