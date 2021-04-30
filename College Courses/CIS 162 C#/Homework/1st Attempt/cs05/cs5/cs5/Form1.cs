/*Programmer: Alex Kolar
 * Date: 3/7/2012-March 7 2012
 * CIS 162 Section 28026
 * Program 4
 */
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
    public partial class Form1 : Form
    {
        const decimal decBlind = 1;
        const decimal decBeforeTime = 1;

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

            decimal decTaxRate, decTaxesDue;

            decimal decFederal, decFirstTime, decPayments;

            decimal decGrandTotal;

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
                                lblTotalDeductions.Text = decTotalDeductions.ToString("n");

                                decGross = decWages - decTotalDeductions;
                                lblGross.Text = decGross.ToString("n");
                                //state and local taxes


                                if (decWages > 60000)
                                {
                                    decTaxRate = 40m;
                                }
                                else if (decWages > 40000)
                                {
                                    decTaxRate = 30m;
                                }
                                else if (decWages > 20000)
                                {
                                    decTaxRate = 20m;
                                }
                                else
                                {
                                    decTaxRate = 0;
                                    decTaxesDue = 0;
                                }

                                lblTaxRate.Text = decTaxRate.ToString("n");
                                decTaxesDue = decTaxRate * decGross;
                                lblTaxesDue.Text = decTaxesDue.ToString("n");



                                txtFederal.Text = decFederal.ToString("n");
                                txtFirstTime.Text = decFirstTime.ToString("n");
                                decPayments = decFirstTime + decFederal;
                                lblPayments.Text = decPayments.ToString("n");

                                // calculate and display Grand Total
                                decGrandTotal = decWages + decTaxesDue + decPayments;
                                lblGrandTotal.Text = decGrandTotal.ToString("n");

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

        private void btnPaymentPlan_Click(object sender, EventArgs e)
        {

        }
    }
}
