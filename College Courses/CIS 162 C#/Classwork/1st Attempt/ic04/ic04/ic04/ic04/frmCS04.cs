//Programmer: John Corker
//Program: ic03
//Class:cis162ad
//Date:2.2.11

//Note: This program does not have error checking. It will "blow up" with
//a run time exception when trying to convert non-numeric data (including blanks) 
//to numeric variables  

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic04
{
    public partial class frmCS04 : Form
    {
        const decimal decAC_PRICE = 500m;
        const decimal decPAINT_PRICE = 1000m;
        const decimal decWHEELS_PRICE = 1500m;


        const decimal decNONE_PRICE = 0m;
        const decimal decONE_YEAR_PRICE = 1500m;
        const decimal decTHREE_YEAR_PRICE = 2000m;
       
        decimal decGrandTotal;
 
        public frmCS04()
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
            if (txtModel.Text != "")
            {
                strModel = txtModel.Text;

                if (txtYear.Text != "")
                {
                    strYear = txtYear.Text;

                    //bring in all numeric data

                    if (decimal.TryParse(txtBasePrice.Text, out decBasePrice))
                    {
  
                        //calculate and display Total Options
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

                        lblTotalOptions.Text = decTotalOptions.ToString("n");

                        if (radNone.Checked)
                        {
                            decExtendedWarranty = decNONE_PRICE;
                        }

                        else if (radOneYear.Checked)
                        {
                            
                            decExtendedWarranty = decONE_YEAR_PRICE;
                        }

                        else if (radThreeYears.Checked)
                        {
                            decExtendedWarranty = decTHREE_YEAR_PRICE;
                        }
                        else
                        {
                            decExtendedWarranty = 0;
                            MessageBox.Show("error on switch");
                            return;
                        }

                        lblExtendedWarranty.Text = decExtendedWarranty.ToString("n");

                        //state and local taxes
                        

                        if (decBasePrice > 50000)
                        {
                            decStateAndLocalTaxes = 2000;
                            decFederalTaxes = 3000;
                            decLicensing = 900;

                        
                        }
                        else if (decBasePrice > 40000)
                        {
                            decStateAndLocalTaxes = 1500;
                            decFederalTaxes = 2000;
                            decLicensing=700;

                        }
                        else if (decBasePrice > 15000)
                        {
                            decStateAndLocalTaxes = 1000;
                            decFederalTaxes = 1000;
                            decLicensing = 500;
                        }
                        else
                        {
                            decStateAndLocalTaxes = 500m;
                            decFederalTaxes = 800m;
                            decLicensing = 150m;
                        }

                        lblStateAndLocalTaxes.Text = decStateAndLocalTaxes.ToString("n");
                        lblFederalTaxes.Text = decFederalTaxes.ToString("n");
                        lblLicensing.Text = decLicensing.ToString("n");

                        //calculate and display total tax and licensing
                        decTotalTaxAndLicensing = decStateAndLocalTaxes + decFederalTaxes + decLicensing;
                        lblTotalTaxAndLicensing.Text = decTotalTaxAndLicensing.ToString("n");

                        //calculate and display Grand Total
                        decGrandTotal = decBasePrice + decTotalOptions+ decExtendedWarranty + decTotalTaxAndLicensing;
                        lblGrandTotal.Text = decGrandTotal.ToString("n");

                        //format and display summary sheet 
                        strSummary = "Model: " + strModel + Environment.NewLine +
                                        "Year: " + strYear + Environment.NewLine +
                                        "Total Options: " + decTotalOptions.ToString("c") + Environment.NewLine +
                                        "Extended Warranty: " + decExtendedWarranty.ToString("c") + Environment.NewLine +
                                        "Total Tax And Licensing: " + decTotalTaxAndLicensing.ToString("c") + Environment.NewLine +
                                        "Grand Total: " + decGrandTotal.ToString("c");
                        lblSummary.Text = strSummary;
 
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
            
        }

        private void frmCS03_Load(object sender, EventArgs e)
        {
            chkAC.Text += " (" + decAC_PRICE.ToString("c0") + ")";
            chkWheels.Text += " (" + decWHEELS_PRICE.ToString("c0") + ")";
            chkPaint.Text += " (" + decPAINT_PRICE.ToString("c0") + ")";

            radOneYear.Text += " (" + decONE_YEAR_PRICE.ToString("c0") + ")";
            radThreeYears.Text += " (" + decTHREE_YEAR_PRICE.ToString("c0") + ")";

        }

        private void btnFinancing_Click(object sender, EventArgs e)
        {
            frmCS05 objCS05 = new frmCS05();
            objCS05.populateFinanceTotal(decGrandTotal);
            objCS05.ShowDialog();
        }
 
    }
}
