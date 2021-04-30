using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ic06_100312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //constants should be public and at the class level
        //so anyone who wants them can see them
        public const decimal AC_PRICE = 1500;
        public const decimal PAINT_PRICE = 500;
        public const decimal WHEELS_PRICE = 1500;

        public const decimal WARRANTY_0_YEARS_PRICE = 0;
        public const decimal WARRANTY_1_YEARS_PRICE = 1200;
        public const decimal WARRANTY_3_YEARS_PRICE = 4500;

        public const decimal BASE_PRICE_BRACKET1 = 50000;
        public const decimal BASE_PRICE_BRACKET2 = 30000;

        public const decimal STATE_TAXES_BRACKET1 = 1000;
        public const decimal FEDERAL_TAXES_BRACKET1 = 2000;
        public const decimal LICENSING_BRACKET1 = 3000;

        public const decimal STATE_TAXES_BRACKET2 = 800;
        public const decimal FEDERAL_TAXES_BRACKET2 = 1500;
        public const decimal LICENSING_BRACKET2 = 2000;

        public const decimal STATE_TAXES_BRACKET3 = 500;
        public const decimal FEDERAL_TAXES_BRACKET3 = 800;
        public const decimal LICENSING_BRACKET3 = 700;
        private decimal decGrandTotal;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strModel, strYear;
            decimal decBasePrice;
            decimal decTotalOptions = 0;
            decimal decStateAndLocalTaxes, decFederalTaxes, decLicensing;
            decimal decTotalTaxAndLicensing;

            decimal decWarrantyAmount;


            string strSummary;


            if (ValidateForm())
            {
                decimal.TryParse(txtBasePrice.Text, out decBasePrice);
                strModel = txtModel.Text;
                strYear = txtYear.Text;

                decTotalOptions = Options();

                lblTotalOptions.Text = decTotalOptions.ToString("n2");

                decWarrantyAmount = Warranty();

                lblWarrantyAmount.Text = decWarrantyAmount.ToString("n2");

                Taxes(decBasePrice, out decStateAndLocalTaxes, 
                                out decFederalTaxes, out decLicensing);

                //if (decBasePrice > BASE_PRICE_BRACKET1)
                //{
                //    decStateAndLocalTaxes = STATE_TAXES_BRACKET1;
                //    decFederalTaxes = FEDERAL_TAXES_BRACKET1;
                //    decLicensing = LICENSING_BRACKET1;
                //}
                //else if (decBasePrice > BASE_PRICE_BRACKET2)
                //{
                //    decStateAndLocalTaxes = STATE_TAXES_BRACKET2;
                //    decFederalTaxes = FEDERAL_TAXES_BRACKET2;
                //    decLicensing = LICENSING_BRACKET2;
                //}
                //else
                //{
                //    decStateAndLocalTaxes = STATE_TAXES_BRACKET3;
                //    decFederalTaxes = FEDERAL_TAXES_BRACKET3;
                //    decLicensing = LICENSING_BRACKET3;
                //}

                lblStateAndLocalTaxes.Text = decStateAndLocalTaxes.ToString("n2");
                lblFederalTaxes.Text = decFederalTaxes.ToString("n2");
                lblLicensing.Text = decLicensing.ToString("n2");

                decTotalTaxAndLicensing = decStateAndLocalTaxes + decFederalTaxes + decLicensing;
                lblTotalTaxAndLicensing.Text = decTotalTaxAndLicensing.ToString("n2");

                decGrandTotal = GrandTotal(decBasePrice, decTotalOptions, decWarrantyAmount, decTotalTaxAndLicensing);
                lblGrandTotal.Text = decGrandTotal.ToString("n2");

                strSummary = "Model:" + strModel +
                            "\nYear:" + strYear +
                            "\nBase Price:" + decBasePrice.ToString("C") +
                            "\nTotal Options:" + decTotalOptions.ToString("C") +
                            "\ntotal Taxes:" + decTotalTaxAndLicensing.ToString("C") +
                            "\nGrand Total:" + decGrandTotal.ToString("C");

                lblSummary.Text = strSummary;

                btnPayments.Enabled = true;


            }
        }

        private decimal GrandTotal(decimal decBasePrice, decimal dectotalOptions, 
                            decimal decWarrantyAmount, decimal decTotalTaxAndLicensing)
        {
            decimal decGrandTotal;

            decGrandTotal = decBasePrice + dectotalOptions + 
                                decWarrantyAmount + decTotalTaxAndLicensing;

            return decGrandTotal;

        }

        private void Taxes(decimal decBasePrice, out decimal decStateAndLocalTaxes,
                        out decimal decFederalTaxes, out decimal decLicensing)
        {
            if (decBasePrice > BASE_PRICE_BRACKET1)
            {
                decStateAndLocalTaxes = STATE_TAXES_BRACKET1;
                decFederalTaxes = FEDERAL_TAXES_BRACKET1;
                decLicensing = LICENSING_BRACKET1;
            }
            else if (decBasePrice > BASE_PRICE_BRACKET2)
            {
                decStateAndLocalTaxes = STATE_TAXES_BRACKET2;
                decFederalTaxes = FEDERAL_TAXES_BRACKET2;
                decLicensing = LICENSING_BRACKET2;
            }
            else
            {
                decStateAndLocalTaxes = STATE_TAXES_BRACKET3;
                decFederalTaxes = FEDERAL_TAXES_BRACKET3;
                decLicensing = LICENSING_BRACKET3;
            }
        }

        private decimal Warranty()
        {
            decimal decWarrantyAmount = 0;

            if (radNone.Checked)
            {
                decWarrantyAmount = WARRANTY_0_YEARS_PRICE;
            }

            else if (radOneYear.Checked)
            {
                decWarrantyAmount = WARRANTY_1_YEARS_PRICE;
            }

            else if (radThreeYears.Checked)
            {
                decWarrantyAmount = WARRANTY_3_YEARS_PRICE;
            }
            else
            {
                decWarrantyAmount = 0;
            }

            return decWarrantyAmount;
        }

        private decimal Options()
        {
            decimal decTotalOpt = 0 ;

            if (chkAC.Checked == true)
            {
                decTotalOpt += AC_PRICE;
            }
            if (chkPaint.Checked)
            {
                decTotalOpt += PAINT_PRICE;
            }
            if (chkWheels.Checked)
            {
                decTotalOpt += WHEELS_PRICE;
            }

            return decTotalOpt;
        }

        private bool ValidateForm()
        {
            bool isValid = false;

            decimal decDummy;

            if (txtModel.Text != "")
            {
                if (txtYear.Text != "")
                {
                    if (decimal.TryParse(txtBasePrice.Text, out decDummy))
                    {
                        isValid = true;
                    }
                    else
                    {
                        MessageBox.Show("Error:Base Price must be numeric");
                        txtBasePrice.Focus();
                        txtBasePrice.SelectAll();
                    }

                }
                else
                {
                    MessageBox.Show("Error:Year is Blank");
                    txtYear.Focus();
                    txtYear.SelectAll();
                }


            }
            else
            {
                MessageBox.Show("Error:Model is Blank");
                txtModel.Focus();
                txtModel.SelectAll();

            }

            return isValid;
        }


        private void btnPayments_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2(decGrandTotal);
            //form2.ShowDialog();

        }
    }
}
