namespace ic09
{
    partial class Form2a
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
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDenominator = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNumerator = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.btnValidateFunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(200, 61);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(13, 13);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "=";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(135, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "------------";
            // 
            // txtDenominator
            // 
            this.txtDenominator.Location = new System.Drawing.Point(142, 77);
            this.txtDenominator.Name = "txtDenominator";
            this.txtDenominator.Size = new System.Drawing.Size(29, 20);
            this.txtDenominator.TabIndex = 14;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(69, 80);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 13);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Denominator";
            // 
            // txtNumerator
            // 
            this.txtNumerator.Location = new System.Drawing.Point(142, 38);
            this.txtNumerator.Name = "txtNumerator";
            this.txtNumerator.Size = new System.Drawing.Size(29, 20);
            this.txtNumerator.TabIndex = 12;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(80, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 13);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Numerator";
            // 
            // lblDecimal
            // 
            this.lblDecimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDecimal.Location = new System.Drawing.Point(234, 60);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(36, 23);
            this.lblDecimal.TabIndex = 19;
            // 
            // btnValidateFunction
            // 
            this.btnValidateFunction.Location = new System.Drawing.Point(343, 31);
            this.btnValidateFunction.Name = "btnValidateFunction";
            this.btnValidateFunction.Size = new System.Drawing.Size(112, 23);
            this.btnValidateFunction.TabIndex = 20;
            this.btnValidateFunction.Text = "Validate Function";
            this.btnValidateFunction.UseVisualStyleBackColor = true;
            this.btnValidateFunction.Click += new System.EventHandler(this.btnValidateFunction_Click);
            // 
            // Form2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 188);
            this.Controls.Add(this.btnValidateFunction);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtDenominator);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtNumerator);
            this.Controls.Add(this.Label1);
            this.Name = "Form2a";
            this.Text = "Form2a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       // internal System.Windows.Forms.Button btnValidateMethod;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtDenominator;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNumerator;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Button btnValidateFunction;
    }
}

