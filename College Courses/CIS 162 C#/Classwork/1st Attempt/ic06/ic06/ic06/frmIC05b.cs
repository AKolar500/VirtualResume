using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic05_021512
{
    public partial class frmIC05b : Form
    {
        public frmIC05b()
        {
            InitializeComponent();
        }
 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal decFinancingTotal, decMonthlyPayment;
            string strSchedule;
            int intPaymentNumber = 0;

            if (decimal.TryParse(txtFinancingTotal.Text, out decFinancingTotal))
            {

                if (decimal.TryParse(txtMonthlyPayment.Text, out decMonthlyPayment))
                {

                    if (decMonthlyPayment > 0)
                    {
                        lstSchedule.Items.Clear();
                        intPaymentNumber = 1;
                        while (decFinancingTotal > 0)
                        {


                            if (decFinancingTotal < decMonthlyPayment)
                            {
                                decMonthlyPayment = decFinancingTotal;
                            }

                            strSchedule = intPaymentNumber.ToString("00") + "\t\t" + decFinancingTotal.ToString("c") + 
                                "\t\t" + decMonthlyPayment.ToString();

                            lstSchedule.Items.Add(strSchedule);

                            intPaymentNumber += 1;

                            decFinancingTotal -= decMonthlyPayment;
                        }


                    }

                    else
                    {
                        MessageBox.Show("Monthly Payment must be greater than 0");
                        txtMonthlyPayment.Focus();
                    }



                }
                else
                {
                    MessageBox.Show("Monthly Payment Total must be numeric");
                    txtMonthlyPayment.Focus();
                }




            }
            else
            {
                MessageBox.Show("Financing Total must be numeric");
                txtFinancingTotal.Focus();
            }



        }
        public void PopulateFinancingTotal(decimal decFinancingTotal)
        {
            txtFinancingTotal.Text = decFinancingTotal.ToString();
        }

 
    }
}
