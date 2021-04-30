/*Alex Kolar
 * 1/23/2013
 * CIS162
 * IC02
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IC02
{
    public partial class Form1 : Form
    {
        decimal decFirstNumber;
        decimal decSecondNumber;
        decimal decResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblOperator.Text = "+";
            lblOpDescription.Text = "Addition";

            decFirstNumber = Convert.ToDecimal(txtFirst.Text);
            decSecondNumber = Convert.ToDecimal(txtSecond.Text);

            decResult = decFirstNumber + decSecondNumber;

            lblResult.Text = decResult.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            lblOperator.Text = "-";
            lblOpDescription.Text = "Subtract";

            decFirstNumber = Convert.ToDecimal(txtFirst.Text);
            decSecondNumber = Convert.ToDecimal(txtSecond.Text);

            decResult = decFirstNumber - decSecondNumber;

            lblResult.Text = decResult.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblOperator.Text = "X";
            lblOpDescription.Text = "Multiply";

            decFirstNumber = Convert.ToDecimal(txtFirst.Text);
            decSecondNumber = Convert.ToDecimal(txtSecond.Text);

            decResult = decFirstNumber * decSecondNumber;

            lblResult.Text = decResult.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblOperator.Text = "/";
            lblOpDescription.Text = "Division";

            decFirstNumber = Convert.ToDecimal(txtFirst.Text);
            decSecondNumber = Convert.ToDecimal(txtSecond.Text);

            decResult = decFirstNumber / decSecondNumber;

            lblResult.Text = decResult.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
