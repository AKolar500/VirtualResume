//programmer:John Corker
//program ic05
//Date:2.26.11
//class:cis162ad


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic06
{
    public partial class frmIC05b : Form
    {
        public frmIC05b()
        {
            InitializeComponent();
        }

        public frmIC05b(decimal decGrandTotal)
        {
            InitializeComponent();

            txtFinancingAmount.Text = decGrandTotal.ToString();

        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal decFinancingAmount, decMonthlyPayment;
            Int32 intNumberOfPayments = 1;
            
            ListViewItem lviSchedule;

            if (decimal.TryParse(txtFinancingAmount.Text, out decFinancingAmount))
            {
                if (decimal.TryParse(txtMonthlyPayment.Text, out decMonthlyPayment))
                {
 
                    lstSchedule.Items.Clear();

                    while (decFinancingAmount > 0)
                    {
                        lviSchedule = new ListViewItem();
 
                        lviSchedule.Text = (intNumberOfPayments).ToString();

                        if (decFinancingAmount >= decMonthlyPayment)
                        {
                            decFinancingAmount -= decMonthlyPayment;
                        }
                        else
                        {
                            decMonthlyPayment = decFinancingAmount; 
                            decFinancingAmount -= decFinancingAmount;
                        }

                        lviSchedule.SubItems.Add(decMonthlyPayment.ToString("c")); 
                        lviSchedule.SubItems.Add(decFinancingAmount.ToString("c"));


                        lstSchedule.Items.Add(lviSchedule);

                        intNumberOfPayments += 1;

                    }
                }
                else//monthly payment error
                {
                    txtMonthlyPayment.Focus();
                    txtMonthlyPayment.SelectAll();
                    MessageBox.Show("Error:Monthly Payment is not numeric");
                }
            }
            else//txtFinancingAmount error
            {
                txtFinancingAmount.Focus();
                txtFinancingAmount.SelectAll();
                MessageBox.Show("Error:txtFinancingAmount is not numeric");           
            }



        }
         
    }
}
