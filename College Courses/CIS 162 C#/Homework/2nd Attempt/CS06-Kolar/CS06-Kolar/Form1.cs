/*Programmer: Alex Kolar
 * Date: 2/27/2013
 * CIS 162 Section 29153
 * CS06 Methods
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
        private bool ValidateData()
        {
            bool isValid = false;
            decimal decDummy1, decDummy2, decDummy3;

            if (txtFirst.Text != "")
            {
                if (txtLast.Text != "")
                {
                    if (decimal.TryParse(txtWages.Text, out decDummy1))
                    {
                        if (decimal.TryParse(txtFederal.Text, out decDummy2))
                        {
                            if (decimal.TryParse(txtFirstTime.Text, out decDummy3))
                            {
                                isValid = true;
                            }
                            else
                            {
                                MessageBox.Show("Error: First Time Home Buyer is not numeric");
                                txtFirstTime.Focus();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error: Federal Taxes is not numeric");
                            txtFederal.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error: Wages is not numeric");
                        txtWages.Focus();
                    }
                    
                }
                else //txtYear error
                {
                    MessageBox.Show("Error: Last Name is Blank");
                    txtLast.Focus();
                }

            }
            else//txtModel error
            {
                MessageBox.Show("Error: First Name is Blank");
                txtFirst.Focus();
            }
            return isValid;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strSummary;
            string strFirst, strLast;

            decimal decWages;

            decimal decDeductions, decTotalDeductions;
            decimal decGross;

            decimal decTaxBox;
            decimal decTaxRate, decTaxesDue;

            decimal decFederal, decFirstTime, decPayments;
            decimal decTotalDue;

            if (ValidateData())
            {
                strFirst = txtFirst.Text;
                strLast = txtLast.Text;
                decWages = Convert.ToDecimal(txtWages.Text);
                decFederal = Convert.ToDecimal(txtFederal.Text);
                decFirstTime = Convert.ToDecimal(txtFirstTime.Text);
                

                Deductions(out decDeductions, out decTotalDeductions);
                lblDeductions.Text = decDeductions.ToString();
                lblTotalDeductions.Text = decTotalDeductions.ToString("c");                

                decGross = Gross(decWages, decTotalDeductions);
                lblGross.Text = decGross.ToString("c");
                //decWarrantyAmount = Warranty();

                //lblWarrantyAmount.Text = decWarrantyAmount.ToString("n2");

                decTaxRate = TaxRate(decGross);
                //Convert tax rate into percent (technically decimal)
                decTaxBox = decTaxRate / 100;
                lblTaxRate.Text = decTaxBox.ToString("n");

                //Calculate taxes due
                decTaxesDue = decTaxBox * decGross;
                lblTaxesDue.Text = decTaxesDue.ToString("c");

                txtFederal.Text = decFederal.ToString("c");
                txtFirstTime.Text = decFirstTime.ToString("c");
                decPayments = decFirstTime + decFederal;
                lblPayments.Text = decPayments.ToString("c");
                //Calculate and display the Total Due
                decTotalDue = decTaxesDue - decPayments;
                lblTotalDue.Text = decTotalDue.ToString("c");

                // calculate and display Grand Total
                decGrandTotal = decGross - decTotalDue;
                lblGrandTotal.Text = decGrandTotal.ToString("c");

                //format and display summary sheet 
                strSummary = strFirst + " " + strLast + Environment.NewLine +
                        "Deductions: " + decTotalDeductions.ToString("c") + Environment.NewLine +
                        "Total Taxes: " + decTaxesDue.ToString("c") + Environment.NewLine +
                        "Payments: " + decPayments.ToString("c") + Environment.NewLine +
                        "Total Due: " + decTotalDue.ToString("c") + Environment.NewLine +
                        "Grand Total: " + decGrandTotal.ToString("c");
                lblSummary.Text = strSummary;
            }
        }
        private decimal Gross(decimal decWages, decimal decTotalDeductions)
        {
            decimal decGross;

            decGross = decWages - decTotalDeductions;
            if (decGross < 0)
            {
                decGross = 0;
            }
            return decGross;
        }
        private decimal TaxRate(decimal decGross)
        {
            decimal decTaxRate;
            //Taxes
            if (decGross >= 60000)
            {
                decTaxRate = TAX_RATE_3;
            }
            else if (decGross >= 40000)
            {
                decTaxRate = TAX_RATE_2;
            }
            else if (decGross >= 20000)
            {
                decTaxRate = TAX_RATE_1;
            }
            else
            {
                decTaxRate = TAX_RATE_1;
            }

            return decTaxRate;
        }
        private void Deductions(out decimal decDeductions, out decimal decTotalDeductions)
        {
            //calculate and display Total Options
            decDeductions = 0;
            if (chkBlind.Checked)
            {
                decDeductions += decBlind;
            }

            if (chkBeforeTime.Checked)
            {
                decDeductions += decBeforeTime;
            }
            decTotalDeductions = decDeductions * 3500;
            
        }
        private void btnPayments_Click(object sender, EventArgs e)
        {
            Form2 frmForm2 = new Form2(decGrandTotal);
            frmForm2.ShowDialog();
        }
    }
}
