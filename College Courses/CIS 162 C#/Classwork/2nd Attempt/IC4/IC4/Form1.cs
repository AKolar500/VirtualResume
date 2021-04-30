using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IC4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const decimal AC_PRICE = 2000;
        const decimal PAINT_PRICE = 1500;
        const decimal WHEELS_PRICE = 2500;

        const decimal WARRANTY_NONE = 0;
        const decimal WARRANTY_ONE_YEAR = 3000;
        const decimal WARRANTY_THREE_YEARS = 5000;

        const decimal BASE_PRICE_BRACKET_1 = 10000;
        const decimal STATE_AND_LOCAL_TAXES_1 = 500;
        const decimal FEDERAL_TAXES_1 = 300;
        const decimal LICENSING_1 = 350;

        const decimal BASE_PRICE_BRACKET_2 = 20000;
        const decimal STATE_AND_LOCAL_TAXES_2 = 1000;
        const decimal FEDERAL_TAXES_2 = 600;
        const decimal LICENSING_2 = 700;

       // const decimal BASE_PRICE_BRACKET_3 = 40000;
        const decimal STATE_AND_LOCAL_TAXES_3 = 2000;
        const decimal FEDERAL_TAXES_3 = 1200;
        const decimal LICENSING_3 = 1400;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strModel, strYear;
            decimal decBasePrice;

            //decimal decAC, decPaint, decWheels;
            decimal decTotalOptions = 0;

            decimal decExtendedWarranty;

            decimal decStateAndLocalTaxes, decFederalTaxes, decLicensing;
            decimal decTotalTaxAndLicensing;

            decimal decGrandTotal;
            decimal decDummy;

            string strSummary;

            if (txtModel.Text != "")
            {
                if (txtYear.Text != "")
                {
                    if (decimal.TryParse(txtBasePrice.Text, out decDummy))
                    {
                        strModel = txtModel.Text;
                        strYear = txtYear.Text;

                        decBasePrice = Convert.ToDecimal(txtBasePrice.Text);

                        if (chkAC.Checked == true)
                        {
                            decTotalOptions += AC_PRICE;
                        }
                        if (chkPaint.Checked)
                        {
                            decTotalOptions += PAINT_PRICE;
                        }
                        if (chkWheels.Checked)
                        {
                            decTotalOptions += WHEELS_PRICE;
                        }
                        lblTotalOptions.Text = decTotalOptions.ToString("c");


                        if (radOneYear.Checked)
                        {
                            decExtendedWarranty = WARRANTY_ONE_YEAR;
                        }
                        else if (radThreeYears.Checked)
                        {
                            decExtendedWarranty = WARRANTY_THREE_YEARS;
                        }
                        else
                        {
                            decExtendedWarranty = WARRANTY_NONE;
                        }
                        lblExtendedWarranty.Text = decExtendedWarranty.ToString("c");


                        if (decBasePrice <= BASE_PRICE_BRACKET_1)
                        {
                            decStateAndLocalTaxes = STATE_AND_LOCAL_TAXES_1;
                            decFederalTaxes = FEDERAL_TAXES_1;
                            decLicensing = LICENSING_1;
                        }
                        else if (decBasePrice <= BASE_PRICE_BRACKET_2)
                        {
                            decStateAndLocalTaxes = STATE_AND_LOCAL_TAXES_2;
                            decFederalTaxes = FEDERAL_TAXES_2;
                            decLicensing = LICENSING_2;
                        }
                        else
                        {
                            decStateAndLocalTaxes = STATE_AND_LOCAL_TAXES_3;
                            decFederalTaxes = FEDERAL_TAXES_3;
                            decLicensing = LICENSING_3;
                        }

                        txtStateAndLocalTaxes.Text = decStateAndLocalTaxes.ToString("c");
                        txtFederalTaxes.Text = decFederalTaxes.ToString("c");
                        txtLicensing.Text = decLicensing.ToString("c");

                        decTotalTaxAndLicensing = decStateAndLocalTaxes + decFederalTaxes + decLicensing;
                        lblTotalTaxAndLicensing.Text = decTotalTaxAndLicensing.ToString("c");

                        decGrandTotal = decBasePrice + decTotalOptions + decExtendedWarranty + decTotalTaxAndLicensing;
                        lblGrandTotal.Text = decGrandTotal.ToString("c");

                        strSummary = "Model: " + strModel + "\n" +
                                    "Year: " + strYear + "\n" +
                                    "Base Price: " + decBasePrice.ToString("c") + "\n" +
                                    "Total Options: " + decTotalOptions.ToString("c") + "\n" +
                                    "Extended Warranty: " + decExtendedWarranty.ToString("c") + "\n" +
                                    "Total Tax & Licensing: " + decTotalTaxAndLicensing.ToString("c") + "\n" +
                                    "Grand Total: " + decGrandTotal.ToString("c") + "\n";
                        lblSummary.Text = strSummary;
                    }
                    else
                    {
                        MessageBox.Show("Error: Base Price cannot be converted to a number");
                        txtBasePrice.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error: Year is Blank");
                    txtYear.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error: Model is Blank");
                txtModel.Focus();
            }
        }
    }
}










