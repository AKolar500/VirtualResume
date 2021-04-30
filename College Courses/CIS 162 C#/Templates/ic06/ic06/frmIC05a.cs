//Programmer: John Corker
//Program: ic06
//Class:cis162ad
//Date:2.2.11

//Note: This program has error checking and uses functions for all calculations
//there is an example of
// 1) a validate function, 
// 2) a function passing variables by value 
// 3) a function passing variable by reference
// 4) several with return values 
// 4) one that returns values by reference AND return value

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
    public partial class frmIC05a : Form
    {
        const decimal decAC_PRICE = 500m;
        const decimal decPAINT_PRICE = 1000m;
        const decimal decWHEELS_PRICE = 1500m;

        const decimal decNONE_PRICE = 0m;
        const decimal decONE_YEAR_PRICE = 1500m;
        const decimal decTHREE_YEAR_PRICE = 2000m;

        decimal[] caryWarrantyVehiclePrice = new decimal[] { 20000, 50000, 80000, 1500000 };
        decimal[] caryOneYearWarrantyFee = new decimal[] { 1000, 2500, 5000, 10000 };
        decimal[] caryThreeYearWarrantyFee = new decimal[] { 2500, 4000, 70000, 20000 };

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

            if (validate())
            {
                strModel = txtModel.Text;
                strYear = txtYear.Text;
                decimal.TryParse(txtBasePrice.Text, out decBasePrice);
  
                //calculate and display Total Options
                decTotalOptions = options();
                lblTotalOptions.Text = decTotalOptions.ToString("n");

                decExtendedWarranty = extendedWarranty(decBasePrice);
                lblExtendedWarranty.Text = decExtendedWarranty.ToString("n");

                decTotalTaxAndLicensing = taxes(decBasePrice, out decStateAndLocalTaxes, out decFederalTaxes,out decLicensing);
                lblStateAndLocalTaxes.Text = decStateAndLocalTaxes.ToString("n");
                lblFederalTaxes.Text = decFederalTaxes.ToString("n");
                lblLicensing.Text = decLicensing.ToString("n");
                lblTotalTaxAndLicensing.Text = decTotalTaxAndLicensing.ToString("n");

                //calculate and display Grand Total
                cdecGrandTotal = grandTotal(decBasePrice, decTotalOptions, decExtendedWarranty, decTotalTaxAndLicensing);
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

        private void frmCS03_Load(object sender, EventArgs e)
        {
            chkAC.Text += " (" + decAC_PRICE.ToString("c0") + ")";
            chkWheels.Text += " (" + decWHEELS_PRICE.ToString("c0") + ")";
            chkPaint.Text += " (" + decPAINT_PRICE.ToString("c0") + ")";

            radOneYear.Text += " (" + decONE_YEAR_PRICE.ToString("c0") + ")";
            radThreeYears.Text += " (" + decTHREE_YEAR_PRICE.ToString("c0") + ")";

        }

        private bool validate() 
        {
            bool isValid = false;
            decimal decTemp;

                       //bring in text data
            if (txtModel.Text != "")
                if (txtYear.Text != "")
                    if (decimal.TryParse(txtBasePrice.Text, out decTemp))
                        if (radNone.Checked || radOneYear.Checked || radThreeYears.Checked)
                            isValid = true;
                        else
                        {
                            MessageBox.Show("Error:No Extended Warranty Selected");
                        }
                    else//base price error
                    {
 
                        MessageBox.Show("Error:Base Price is not numeric");
                        txtBasePrice.Focus();
                        txtBasePrice.SelectAll();

                    }
                else //txtYear error
                {
                    MessageBox.Show("Error:Year is Blank");
                    txtYear.Focus();
                }
            else//txtModel error
            {
                MessageBox.Show("Error:Model is Blank");
                txtModel.Focus();
            }
            return isValid;
        }
        private decimal options()
        { 
            decimal decOptions = 0;

            if (chkAC.Checked)
                decOptions = decAC_PRICE;

            if (chkPaint.Checked)
                decOptions += decPAINT_PRICE;

            if (chkWheels.Checked)
                decOptions += decWHEELS_PRICE;
 
            return decOptions;
        }

        private decimal extendedWarranty(decimal decBasePrice)
        {
            decimal decExtendedWarranty  = 0;

            for (int i = 0; i < caryWarrantyVehiclePrice.Length; i++)
            {
                if (decBasePrice <= caryWarrantyVehiclePrice[i])
                {
                    if (radNone.Checked)
                        decExtendedWarranty = decNONE_PRICE;
                    else if (radOneYear.Checked)
                        decExtendedWarranty = caryOneYearWarrantyFee[i];
                    else if (radThreeYears.Checked)
                        decExtendedWarranty = caryThreeYearWarrantyFee[i];
                    break;
                    //else
                    //    decExtendedWarranty = 0;
                }
            }

            return decExtendedWarranty;
        }
               
        private decimal taxes(decimal decBasePrice, out decimal decStateAndLocalTaxes, out  decimal decFederalTaxes, out  decimal decLicensing)
                //state and local taxes
        {
            decimal decTotalStateAndLocalTaxes;                
            
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
                decLicensing=700m;
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

            decTotalStateAndLocalTaxes = decStateAndLocalTaxes + decFederalTaxes + decLicensing;
            return decTotalStateAndLocalTaxes;
        }

        private decimal grandTotal(decimal decBasePrice, decimal decTotalOptions, decimal decExtendedWarranty, decimal decTotalTaxAndLicensing)
        {
            decimal decGrandTotal;
            decGrandTotal = decBasePrice + decTotalOptions+ decExtendedWarranty + decTotalTaxAndLicensing;
            return decGrandTotal;
        
        }

        private void btnFinacing_Click(object sender, EventArgs e)
        {
            frmIC05b objIC05b = new frmIC05b(cdecGrandTotal);

            objIC05b.ShowDialog();
        }
    }
}
