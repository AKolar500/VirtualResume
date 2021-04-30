namespace ic11
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
            this.lblDecimal = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDenominator = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNumerator = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnNoExceptionHandling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDecimal
            // 
            this.lblDecimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDecimal.Location = new System.Drawing.Point(246, 107);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(36, 23);
            this.lblDecimal.TabIndex = 26;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(212, 108);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(13, 13);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "=";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(147, 108);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 13);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "------------";
            // 
            // txtDenominator
            // 
            this.txtDenominator.Location = new System.Drawing.Point(154, 124);
            this.txtDenominator.Name = "txtDenominator";
            this.txtDenominator.Size = new System.Drawing.Size(29, 20);
            this.txtDenominator.TabIndex = 23;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(81, 127);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 13);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Denominator";
            // 
            // txtNumerator
            // 
            this.txtNumerator.Location = new System.Drawing.Point(154, 85);
            this.txtNumerator.Name = "txtNumerator";
            this.txtNumerator.Size = new System.Drawing.Size(29, 20);
            this.txtNumerator.TabIndex = 21;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(92, 88);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Numerator";
            // 
            // btnNoExceptionHandling
            // 
            this.btnNoExceptionHandling.Location = new System.Drawing.Point(391, 56);
            this.btnNoExceptionHandling.Name = "btnNoExceptionHandling";
            this.btnNoExceptionHandling.Size = new System.Drawing.Size(137, 23);
            this.btnNoExceptionHandling.TabIndex = 27;
            this.btnNoExceptionHandling.Text = "No Exception Handling";
            this.btnNoExceptionHandling.UseVisualStyleBackColor = true;
            this.btnNoExceptionHandling.Click += new System.EventHandler(this.btnNoExceptionHandling_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 277);
            this.Controls.Add(this.btnNoExceptionHandling);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtDenominator);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtNumerator);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecimal;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtDenominator;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNumerator;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnNoExceptionHandling;
    }
}

