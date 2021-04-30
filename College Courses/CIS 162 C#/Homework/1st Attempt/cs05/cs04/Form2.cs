using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strSchedule;
            int intPaymentNumber = 0;
            int intPeriods;
            int intTotalDue;

            if (int.TryParse(txtTotalDue.Text, out intTotalDue))
            {

                if (int.TryParse(txtPeriods.Text, out intPeriods))
                {

                    if(intTotalDue > 0)
                    {
                        lstSchedule.Items.Clear();
                        intPaymentNumber = 1;
                        for (int intPayment = 0; intPayment < intPeriods; intPayment++)
			            {


                            if (intTotalDue > intPeriods)
                            {
                                intPeriods = intTotalDue;
                            }

                            strSchedule = intPaymentNumber.ToString("00") + "\t\t" +  intPeriods.ToString() +
                                "\t\t" + intTotalDue.ToString("c");

                            lstSchedule.Items.Add(strSchedule);

                            intPaymentNumber += 1;

                            intTotalDue -= intPeriods;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Monthly Payment must be greater than 0");
                        txtPeriods.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Monthly Payment Total must be numeric");
                    txtPeriods.Focus();
                }
            }
            else
            {
                MessageBox.Show("Financing Total must be numeric");
                txtTotalDue.Focus();
            }
        }
    }
}
