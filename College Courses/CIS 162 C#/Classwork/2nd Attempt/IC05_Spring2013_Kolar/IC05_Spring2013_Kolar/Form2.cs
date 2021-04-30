using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IC05_Spring2013_Kolar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(decimal decFinancingTotal)
        {
            InitializeComponent();

            txtFinancingTotal.Text = decFinancingTotal.ToString();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            decimal decFinancingTotal, decMonthlyPayment;
           // decimal decGrandTotal;

           // int i;
            int intPaymentNumber;

            string strLine;

            if (decimal.TryParse(txtFinancingTotal.Text, out decFinancingTotal))
            {
                if (decimal.TryParse(txtMonthlyPayment.Text, out decMonthlyPayment))
                {
                    lstSchedule.Items.Clear();

                    //i = 1;
                    //while (decFinancingTotal >= 0)
                    //{
                    //    strLine = i.ToString() + "\t\t" + decMonthlyPayment.ToString("c") +
                    //        "\t\t" + decFinancingTotal.ToString("c");
                    //    lstSchedule.Items.Add(strLine);

                    //    i++;
                    //    decFinancingTotal = decFinancingTotal - decMonthlyPayment;
                    //}
                    intPaymentNumber = (int)(decFinancingTotal / decMonthlyPayment);

                    for (int i = 1; i < intPaymentNumber; i++)
                    {
                        strLine = i.ToString() + "\t\t" + decMonthlyPayment.ToString("c") +
                            "\t\t" + decFinancingTotal.ToString("c");
                        lstSchedule.Items.Add(strLine);

                        decFinancingTotal = decFinancingTotal - decMonthlyPayment;
                    }
                }
                else
                {
                    MessageBox.Show("Monthly Payment is not numeric.");
                    txtMonthlyPayment.Text = "";
                    txtMonthlyPayment.Focus();
                }
            }
            else
            {
                MessageBox.Show("Financing Total is not numeric.");
                txtFinancingTotal.Text = "";
                txtFinancingTotal.Focus();
            }
        }
    }
}
