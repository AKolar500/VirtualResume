/*Alex Kolar
 * 2/19-20/2013
 * CIS162AD Section 29153
 * CS05 Loops
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS05_Kolar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(decimal decTotalAmountDue)
        {
            InitializeComponent();

            txtTotalAmountDue.Text = decTotalAmountDue.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal decTotalAmountDue, decPaymentNumber, decPaymentAmount;

            string strLine;

            if (decimal.TryParse(txtTotalAmountDue.Text, out decTotalAmountDue))
            {
                if (decimal.TryParse(txtNumberOfPeriods.Text, out decPaymentNumber))
                {
                    //Clear the payments box
                    lstPayments.Items.Clear();

                    //determine the value of the payment amount.
                    decPaymentAmount = decTotalAmountDue / decPaymentNumber;

                    //Do the important stuff
                    for (int i = 0; i <= decPaymentNumber; i++)
                    {
                        //Print the payments
                        strLine = i.ToString() + "\t\t" + decPaymentAmount.ToString("c") +
                            "\t\t" + decTotalAmountDue.ToString("c");
                        lstPayments.Items.Add(strLine);

                        //this is the actual calculation that determines the remaining Principal
                        decTotalAmountDue = decTotalAmountDue - decPaymentAmount;
                    }
                }
                else
                {
                    MessageBox.Show("Number of Payments is not numeric.");
                    txtNumberOfPeriods.Text = "";
                    txtNumberOfPeriods.Focus();
                }
            }
            else
            {
                MessageBox.Show("Total Due is not numeric.");
                txtTotalAmountDue.Text = "";
                txtTotalAmountDue.Focus();
            }
        }
    }
}
