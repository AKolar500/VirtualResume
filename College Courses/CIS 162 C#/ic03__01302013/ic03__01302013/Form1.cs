using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic03__01302013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strModel, strYear;
            decimal decBasePrice;

            decimal decAC, decPaint, decWheels;
            decimal decTotalOptions;

            decimal decStateAndLocalTaxes, decFederalTaxes, decLicensing;
            decimal decTotalTaxAndLicensing;

            decimal decGrandTotal;

            string strSummary;

            strModel = txtModel.Text;
            strYear = txtYear.Text;

            decBasePrice = Convert.ToDecimal(txtBasePrice.Text);

            decAC = Convert.ToDecimal(txtAC.Text);
            decPaint = Convert.ToDecimal(txtPaint.Text);
            decWheels = Convert.ToDecimal(txtWheels.Text);

            decTotalOptions = decAC + decPaint + decWheels;
            lblTotalOptions.Text = decTotalOptions.ToString("c");

            decStateAndLocalTaxes = Convert.ToDecimal(txtStateAndLocalTaxes.Text);
            decFederalTaxes = Convert.ToDecimal(txtFederalTaxes.Text);
            decLicensing = Convert.ToDecimal(txtLicensing.Text);

            decTotalTaxAndLicensing = decStateAndLocalTaxes + decFederalTaxes + decLicensing;

            lblTotalTaxAndLicensing.Text = decTotalTaxAndLicensing.ToString("c");

            decGrandTotal = decBasePrice + decTotalOptions + decTotalTaxAndLicensing;
            lblGrandTotal.Text = decGrandTotal.ToString("c");

            strSummary = "Model: " + strModel + "\n" +
                        "Year: " + strYear + "\n" +
                        "Base Price: " + decBasePrice.ToString("c") + "\n" +
                        "Total Options: " + decTotalOptions.ToString("c") + "\n" +
                        "Total Tax & Licensing: " + decTotalTaxAndLicensing.ToString("c") + "\n" +
                        "Grand Total: " + decGrandTotal.ToString("c") + "\n"; 
         lblSummary.Text = strSummary;

        }
    }
}










