/*Programmer: Alex Kolar
 * 2/15/2012
 * CIS162 Section 28026
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic04
{
    public partial class frmCS05 : Form
    {
        public frmCS05()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal decFinancingTotal, decMonthlyPayment;

            string strSchedule;

            int intPaymentNumber;

            if (decimal.TryParse(txtFinancingTotal.Text, out decFinancingTotal))
            {
                if (decimal.TryParse(txtMonthlyPayment.Text, out decMonthlyPayment))
                {
                    lstSchedule.Items.Clear();

                    intPaymentNumber = 1;
                    while (decFinancingTotal > 0)
                    {
                        strSchedule = intPaymentNumber.ToString() + "\t\t\t";

                        if (decFinancingTotal < decMonthlyPayment)
                        {
                            decMonthlyPayment = decFinancingTotal;
                        }

                        decFinancingTotal -= decMonthlyPayment;
                        strSchedule += decFinancingTotal.ToString();

                        strSchedule += "\t\t" + decMonthlyPayment.ToString();

                        lstSchedule.Items.Add(strSchedule);

                        intPaymentNumber++;
                    }
                }
                else
                {
                    MessageBox.Show("Error on Monthly Payment");
                    txtMonthlyPayment.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error on Financing Total");
                txtFinancingTotal.Focus();
            }
        }
        public void populateFinanceTotal(decimal decFinanceTotal)
        {
            txtFinancingTotal.Text = decFinanceTotal.ToString();
        }
    }
}
