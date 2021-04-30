//Programmer: Alex Kolar
//Program: ic06
//Class:cis162ad Section 28026
//Date:2.22.2012

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
    public partial class frmIC05a : Form
    {
        const decimal decAC_PRICE = 500m;
        const decimal decPAINT_PRICE = 1000m;
        const decimal decWHEELS_PRICE = 1500m;


        const decimal decNONE_PRICE = 0m;
        const decimal decONE_YEAR_PRICE = 1500m;
        const decimal decTHREE_YEAR_PRICE = 2000m;


        private decimal cdecGrandTotal;

        public frmIC05a()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //define internal variables for all controls "used in code"
            string strModel, strYear;

            decimal decBasePrice;

            decimal decTotalOptions;
            decimal decExtendedWarranty;
            decimal decStateAndLocalTaxes, decFederalTaxes, decLicensing, decTotalTaxAndLicensing;


            string strSummary;

            //bring in text data
            if (validate())
            {
                strModel = txtModel.Text;
                strYear = txtYear.Text;
                decimal.TryParse(txtBasePrice.Text, out decBasePrice);

                //calculate and display Total Options
                decTotalOptions = Options();//calls the Options method to do its job
                lblTotalOptions.Text = decTotalOptions.ToString("n");
                //
                decExtendedWarranty = ExtendedWarranty();//calls the ExtendedWarranty method
                lblExtendedWarranty.Text = decExtendedWarranty.ToString("n");

                //state and local taxes
                Taxes(decBasePrice, out decStateAndLocalTaxes, out decFederalTaxes, out decLicensing);


                lblStateAndLocalTaxes.Text = decStateAndLocalTaxes.ToString("n");
                lblFederalTaxes.Text = decFederalTaxes.ToString("n");
                lblLicensing.Text = decLicensing.ToString("n");

                //calculate and display total tax and licensing
                decTotalTaxAndLicensing = decStateAndLocalTaxes + decFederalTaxes + decLicensing;
                lblTotalTaxAndLicensing.Text = decTotalTaxAndLicensing.ToString("n");

                //calculate and display Grand Total
                cdecGrandTotal = GrandTotal(decBasePrice, decTotalOptions, decExtendedWarranty, decTotalTaxAndLicensing);
                lblGrandTotal.Text = cdecGrandTotal.ToString("n");

                //format and display summary sheet 
                strSummary = "Model: " + strModel + Environment.NewLine +
                                "Year: " + strYear + Environment.NewLine +
                                "Total Options: " + decTotalOptions.ToString("c") + Environment.NewLine +
                                "Extended Warranty: " + decExtendedWarranty.ToString("c") + Environment.NewLine +
                                "Total Tax And Licensing: " + decTotalTaxAndLicensing.ToString("c") + Environment.NewLine +
                                "Grand Total: " + cdecGrandTotal.ToString("c");
                lblSummary.Text = strSummary;
            }
        }
        private decimal Options()
        {
            decimal decTotalOptions;

            decTotalOptions = 0;
            if (chkAC.Checked)
            {
                decTotalOptions = decAC_PRICE;
            }

            if (chkPaint.Checked)
            {
                decTotalOptions += decPAINT_PRICE;
            }

            if (chkWheels.Checked)
            {
                decTotalOptions += decWHEELS_PRICE;
            }
            return decTotalOptions;
        }
        private decimal ExtendedWarranty()
        {
            decimal decExtendedWarranty;
            if (radNone.Checked)
                decExtendedWarranty = decNONE_PRICE;
            else if (radOneYear.Checked)
                decExtendedWarranty = decONE_YEAR_PRICE;
            else if (radThreeYears.Checked)
                decExtendedWarranty = decTHREE_YEAR_PRICE;
            else
                decExtendedWarranty = 0;
            return decExtendedWarranty;
        }
        private void Taxes(decimal decBasePrice, out decimal decStateAndLocalTaxes, out decimal decFederalTaxes, out decimal decLicensing)
        {
            if (decBasePrice > 50000m)
            {
                decStateAndLocalTaxes = 2000m;
                decFederalTaxes = 3000m;
                decLicensing = 900m;
            }
            else if (decBasePrice > 40000m)
            {
                decStateAndLocalTaxes = 1500m;
                decFederalTaxes = 2000m;
                decLicensing = 700m;

            }
            else if (decBasePrice > 15000m)
            {
                decStateAndLocalTaxes = 1000m;
                decFederalTaxes = 1000m;
                decLicensing = 500m;
            }
            else
            {
                decStateAndLocalTaxes = 500m;
                decFederalTaxes = 800m;
                decLicensing = 150m;
            }
        }
        private decimal GrandTotal(decimal decBP, decimal decTO, decimal decEW, decimal decTTL)
        {
            decimal decGrandTotal;
            decGrandTotal = decBP + decTO + decEW + decTTL;
            return decGrandTotal;
        }
        private bool validate()
        {
            decimal decBasePrice;
            bool isValid = false;

            if (txtModel.Text != "")
            {
                if (txtYear.Text != "")
                {
                    if (decimal.TryParse(txtBasePrice.Text, out decBasePrice))
                    {
                        isValid = true;
                    }
                    else//base price error
                    {
                        MessageBox.Show("Error:Base Price is not numeric");
                        txtBasePrice.Focus();
                    }

                }
                else //txtYear error
                {
                    MessageBox.Show("Error:Year is Blank");
                    txtYear.Focus();
                }
            }
            else//txtModel error
            {
                MessageBox.Show("Error:Model is Blank");
                txtModel.Focus();

            }
            return isValid;
        }
        private void frmCS03_Load(object sender, EventArgs e)
        {
            chkAC.Text += " (" + decAC_PRICE.ToString("c0") + ")";
            chkWheels.Text += " (" + decWHEELS_PRICE.ToString("c0") + ")";
            chkPaint.Text += " (" + decPAINT_PRICE.ToString("c0") + ")";

            radOneYear.Text += " (" + decONE_YEAR_PRICE.ToString("c0") + ")";
            radThreeYears.Text += " (" + decTHREE_YEAR_PRICE.ToString("c0") + ")";

        }

        private void btnFinacing_Click(object sender, EventArgs e)
        {
            frmIC05b objIC05b = new frmIC05b();
            objIC05b.PopulateFinancingTotal(cdecGrandTotal);

            objIC05b.ShowDialog();

        }



    }
}
