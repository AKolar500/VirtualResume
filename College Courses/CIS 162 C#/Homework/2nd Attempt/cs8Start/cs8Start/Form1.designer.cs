namespace cs08
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSesameQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSesame = new System.Windows.Forms.CheckBox();
            this.chkPoppy = new System.Windows.Forms.CheckBox();
            this.chkRaisin = new System.Windows.Forms.CheckBox();
            this.lblSesameSeedTotal = new System.Windows.Forms.Label();
            this.txtRaisinQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPoppyTotal = new System.Windows.Forms.Label();
            this.lblRaisinTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelIHateThisWretchedProgram = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.txtPoppyQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill\'s Bagel Barn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type of Bagel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // txtSesameQty
            // 
            this.txtSesameQty.Location = new System.Drawing.Point(222, 107);
            this.txtSesameQty.Name = "txtSesameQty";
            this.txtSesameQty.Size = new System.Drawing.Size(46, 20);
            this.txtSesameQty.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "x $.50";
            // 
            // chkSesame
            // 
            this.chkSesame.AutoSize = true;
            this.chkSesame.Location = new System.Drawing.Point(78, 113);
            this.chkSesame.Name = "chkSesame";
            this.chkSesame.Size = new System.Drawing.Size(92, 17);
            this.chkSesame.TabIndex = 6;
            this.chkSesame.Text = "Sesame Seed";
            this.chkSesame.UseVisualStyleBackColor = true;
            this.chkSesame.CheckedChanged += new System.EventHandler(this.chkSesame_CheckedChanged);
            // 
            // chkPoppy
            // 
            this.chkPoppy.AutoSize = true;
            this.chkPoppy.Location = new System.Drawing.Point(78, 141);
            this.chkPoppy.Name = "chkPoppy";
            this.chkPoppy.Size = new System.Drawing.Size(84, 17);
            this.chkPoppy.TabIndex = 7;
            this.chkPoppy.Text = "Poppy Seed";
            this.chkPoppy.UseVisualStyleBackColor = true;
            this.chkPoppy.CheckedChanged += new System.EventHandler(this.chkPoppy_CheckedChanged);
            // 
            // chkRaisin
            // 
            this.chkRaisin.AutoSize = true;
            this.chkRaisin.Location = new System.Drawing.Point(78, 167);
            this.chkRaisin.Name = "chkRaisin";
            this.chkRaisin.Size = new System.Drawing.Size(105, 17);
            this.chkRaisin.TabIndex = 8;
            this.chkRaisin.Text = "Raisin Cinnamon";
            this.chkRaisin.UseVisualStyleBackColor = true;
            this.chkRaisin.CheckedChanged += new System.EventHandler(this.chkRaisin_CheckedChanged);
            // 
            // lblSesameSeedTotal
            // 
            this.lblSesameSeedTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSesameSeedTotal.Location = new System.Drawing.Point(371, 104);
            this.lblSesameSeedTotal.Name = "lblSesameSeedTotal";
            this.lblSesameSeedTotal.Size = new System.Drawing.Size(68, 23);
            this.lblSesameSeedTotal.TabIndex = 9;
            // 
            // txtRaisinQty
            // 
            this.txtRaisinQty.Location = new System.Drawing.Point(222, 164);
            this.txtRaisinQty.Name = "txtRaisinQty";
            this.txtRaisinQty.Size = new System.Drawing.Size(46, 20);
            this.txtRaisinQty.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "x $.50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "x $.50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Each";
            // 
            // lblPoppyTotal
            // 
            this.lblPoppyTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPoppyTotal.Location = new System.Drawing.Point(371, 132);
            this.lblPoppyTotal.Name = "lblPoppyTotal";
            this.lblPoppyTotal.Size = new System.Drawing.Size(68, 23);
            this.lblPoppyTotal.TabIndex = 16;
            // 
            // lblRaisinTotal
            // 
            this.lblRaisinTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRaisinTotal.Location = new System.Drawing.Point(371, 157);
            this.lblRaisinTotal.Name = "lblRaisinTotal";
            this.lblRaisinTotal.Size = new System.Drawing.Size(68, 23);
            this.lblRaisinTotal.TabIndex = 17;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(371, 200);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 23);
            this.lblSubtotal.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Subtotal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(371, 262);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 23);
            this.lblTotal.TabIndex = 20;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(474, 63);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(474, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelIHateThisWretchedProgram
            // 
            this.labelIHateThisWretchedProgram.AutoSize = true;
            this.labelIHateThisWretchedProgram.Location = new System.Drawing.Point(311, 240);
            this.labelIHateThisWretchedProgram.Name = "labelIHateThisWretchedProgram";
            this.labelIHateThisWretchedProgram.Size = new System.Drawing.Size(36, 13);
            this.labelIHateThisWretchedProgram.TabIndex = 25;
            this.labelIHateThisWretchedProgram.Text = "Taxes";
            // 
            // lblTaxes
            // 
            this.lblTaxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxes.Location = new System.Drawing.Point(371, 230);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(68, 23);
            this.lblTaxes.TabIndex = 24;
            // 
            // txtPoppyQty
            // 
            this.txtPoppyQty.Location = new System.Drawing.Point(222, 138);
            this.txtPoppyQty.Name = "txtPoppyQty";
            this.txtPoppyQty.Size = new System.Drawing.Size(46, 20);
            this.txtPoppyQty.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 355);
            this.Controls.Add(this.txtPoppyQty);
            this.Controls.Add(this.labelIHateThisWretchedProgram);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblRaisinTotal);
            this.Controls.Add(this.lblPoppyTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRaisinQty);
            this.Controls.Add(this.lblSesameSeedTotal);
            this.Controls.Add(this.chkRaisin);
            this.Controls.Add(this.chkPoppy);
            this.Controls.Add(this.chkSesame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSesameQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSesameQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSesame;
        private System.Windows.Forms.CheckBox chkPoppy;
        private System.Windows.Forms.CheckBox chkRaisin;
        private System.Windows.Forms.Label lblSesameSeedTotal;
        private System.Windows.Forms.TextBox txtRaisinQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPoppyTotal;
        private System.Windows.Forms.Label lblRaisinTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelIHateThisWretchedProgram;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.TextBox txtPoppyQty;
    }
}

