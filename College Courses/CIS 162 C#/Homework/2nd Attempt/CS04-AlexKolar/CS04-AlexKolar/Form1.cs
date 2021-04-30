/*Alex Kolar
 * 2/13/2013
 * CIS162AD 29153
 * CS04
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS04_AlexKolar
{
    public partial class Form1 : Form
    {
        const decimal TAX_RATE_1 = 2000;
        const decimal TAX_RATE_2 = 3000;
        const decimal TAX_RATE_3 = 4000;

        const decimal BORN_1946 = 1;
        const decimal BLIND = 1;
        const decimal NO_DEDUCTIONS = 0;
        const decimal EACH_DEDUCTION = 3500;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strFirstName, strLastName;
            decimal decWages, decGrossIncome, decTotalDue;

            decimal decNumberOfDeductions, decTotalDeductions;
            decimal decTaxRate, decTaxBox, decTaxesDue;
            decimal decFederal, decFirstTime, decTotalPayments;

            string strSummary;

            if (txtFirstName.Text != "")
            {
                if (txtLastName.Text != "")
                {
                    if (decimal.TryParse(txtWagesSalariesTips.Text, out decWages))
                    {
                        if (decimal.TryParse(txtFederalIncomeTaxWithheld.Text, out decFederal))
                        {
                            if (decimal.TryParse(txtFirstTimeHomeBuyer.Text, out decFirstTime))
                            {
                                //Operations in the Name GroupBox
                                strFirstName = txtFirstName.Text;
                                strLastName = txtLastName.Text;

                                //Operations in the Deductions GroupBox
                                decNumberOfDeductions = Convert.ToDecimal(lblNumberOfDeductions.Text);

                                //Handle the check boxes
                                if (chkBornBefore1946.Checked)
                                {
                                    decNumberOfDeductions += BORN_1946;
                                }
                                if (chkBlind.Checked)
                                {
                                    decNumberOfDeductions += BLIND;
                                }
                                else
                                {
                                    decNumberOfDeductions = NO_DEDUCTIONS;
                                }

                                //Handle the total Deductions
                                decTotalDeductions = decNumberOfDeductions * EACH_DEDUCTION;
                                lblTotalDeductions.Text = decTotalDeductions.ToString("c");

                                //Handle the gross income
                                decGrossIncome = decWages - decTotalDeductions;
                                lblGrossIncome.Text = decGrossIncome.ToString("c");

                                if (decGrossIncome < 0)
                                {
                                    decGrossIncome = 0;
                                }

                                //Operations in the Taxes GroupBox
                                if (decGrossIncome >= 60000)
                                {
                                    decTaxRate = TAX_RATE_3;
                                }
                                else if (decGrossIncome >= 40000)
                                {
                                    decTaxRate = TAX_RATE_2;
                                }
                                else
                                {
                                    decTaxRate = TAX_RATE_1;
                                }

                                //Make the tax rate a percentage (divide by 100)
                                decTaxBox = decTaxRate / 100;
                                lblTaxesDue.Text = decTaxBox.ToString("d");
                            }
                            else
                            {
                                MessageBox.Show("First Time Home Buyer is not numeric");
                                txtFirstTimeHomeBuyer.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Federal Income Tax Withheld is not numeric");
                            txtFederalIncomeTaxWithheld.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wages, Salaries, Tips is not numeric");
                        txtWagesSalariesTips.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Last Name needs to be filled in.");
                    txtLastName.Focus();
                }
            }
            else
            {
                MessageBox.Show("First Name needs to be filled in.");
                txtFirstName.Focus();
            }
        }
    }
}
