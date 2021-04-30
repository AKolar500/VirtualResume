/*Programmer: Alex Kolar
 * Date: 2/13/2013
 * CIS 162 Section 29153
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

namespace CS05_Kolar
{
    public partial class Form1 : Form
    {
        const decimal decBlind = 1;
        const decimal decBeforeTime = 1;

        const decimal TAX_RATE_1 = 20;
        const decimal TAX_RATE_2 = 30;
        const decimal TAX_RATE_3 = 40;

        decimal decGrandTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strFirst, strLast;
            string strSummary;

            decimal decWages;

            decimal decDeductions, decTotalDeductions;
            decimal decGross;

            decimal decTaxBox;
            decimal decTaxRate, decTaxesDue;

            decimal decFederal, decFirstTime, decPayments;

            if (txtFirst.Text != "")
            {
                strFirst = txtFirst.Text;

                if (txtLast.Text != "")
                {
                    strLast = txtLast.Text;

                    //bring in all numeric data

                    if (decimal.TryParse(txtWages.Text, out decWages))
                    {
                        if (decimal.TryParse(txtFederal.Text, out decFederal))
                        {
                            if (decimal.TryParse(txtFirstTime.Text, out decFirstTime))
                            {
                                //calculate and display Total Options
                                decDeductions = 0;
                                if (chkBlind.Checked)
                                {
                                    decDeductions = decBlind;
                                }

                                if (chkBeforeTime.Checked)
                                {
                                    decDeductions += decBeforeTime;
                                }

                                lblDeductions.Text = decDeductions.ToString();
                                decTotalDeductions = decDeductions * 3500;
                                lblTotalDeductions.Text = decTotalDeductions.ToString("c");

                                decGross = decWages - decTotalDeductions;
                                lblGross.Text = decGross.ToString("c");

                                if (decGross < 0)
                                {
                                    decGross = 0;
                                }
                                
                                //Taxes
                                if (decWages >= 60000)
                                {
                                    decTaxRate = TAX_RATE_3;
                                }
                                else if (decWages >= 40000)
                                {
                                    decTaxRate = TAX_RATE_2;
                                }
                                else if (decWages >= 20000)
                                {
                                    decTaxRate = TAX_RATE_1;
                                }
                                else
                                {
                                    decTaxRate = TAX_RATE_1;
                                }
                                //Convert into percent (technically decimal)
                                decTaxBox = decTaxRate / 100;
                                lblTaxRate.Text = decTaxBox.ToString("n");

                                //Calculate taxes due
                                decTaxesDue = decTaxBox * decGross;
                                lblTaxesDue.Text = decTaxesDue.ToString("c");



                                txtFederal.Text = decFederal.ToString("c");
                                txtFirstTime.Text = decFirstTime.ToString("c");
                                decPayments = decFirstTime + decFederal;
                                lblPayments.Text = decPayments.ToString("c");

                                // calculate and display Grand Total
                                decGrandTotal = decWages + decTaxesDue + decPayments;
                                lblGrandTotal.Text = decGrandTotal.ToString("c");

                                //format and display summary sheet 
                                strSummary = strFirst + " " + strLast + Environment.NewLine +
                                        "Deductions: " + decTotalDeductions.ToString("c") + Environment.NewLine +
                                        "Total Taxes: " + decTaxesDue.ToString("c") + Environment.NewLine +
                                        "Payments: " + decPayments.ToString("c") + Environment.NewLine +
                                        "Grand Total: " + decGrandTotal.ToString("c");
                                lblSummary.Text = strSummary;
                            }
                            else
                            {
                                MessageBox.Show("Error: First Time Home Buyer is not numeric");
                                txtFirstTime.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Federal is not numeric");
                            txtFederal.Focus();
                        }
                      }
                    else//base price error
                    {
                        MessageBox.Show("Error:Wages is not numeric");
                        txtWages.Focus();
                    }
                }
                else //txtYear error
                {
                    MessageBox.Show("Error:Last Name is Blank");
                    txtLast.Focus();
                }
            }
            else//txtModel error
            {
                MessageBox.Show("Error:First is Blank");
                txtFirst.Focus();
            }
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Form2 frmForm2 = new Form2(decGrandTotal);
            frmForm2.ShowDialog();

        }
    }
}
