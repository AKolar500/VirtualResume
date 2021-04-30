//Programmer: Alex Kolar
//January 25, 2012
//CIS162 Section 28026


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal decNumber1, decNumber2, decResult;
            decNumber1 = Convert.ToDecimal(txtNumber1.Text); //Convert # 1 to a decimal
            decNumber2 = Convert.ToDecimal(txtNumber2.Text);
            decResult = decNumber1 + decNumber2; //Perform the operation
            lblResult.Text = decResult.ToString(); //Show the result
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            decimal decNumber1, decNumber2, decResult;
            decNumber1 = Convert.ToDecimal(txtNumber1.Text);
            decNumber2 = Convert.ToDecimal(txtNumber2.Text);
            decResult = decNumber1 - decNumber2;
            lblResult.Text = decResult.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal decNumber1, decNumber2, decResult;
            decNumber1 = Convert.ToDecimal(txtNumber1.Text);
            decNumber2 = Convert.ToDecimal(txtNumber2.Text);
            decResult = decNumber1 * decNumber2;
            lblResult.Text = decResult.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal decNumber1, decNumber2, decResult;
            decNumber1 = Convert.ToDecimal(txtNumber1.Text);
            decNumber2 = Convert.ToDecimal(txtNumber2.Text);
            decResult = decNumber1 / decNumber2;
            lblResult.Text = decResult.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
