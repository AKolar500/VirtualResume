using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IC03
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
            decimal decTotalTaxes;

            decimal decGrandTotal;

            string strSummary;

            strModel = txtModel.Text;
            strYear = txtYear.Text;

            decBasePrice = Convert.ToDecimal(txtBasePrice.Text);

            decAC = Convert.ToDecimal(txtAC.Text);
            decPaint = Convert.ToDecimal(txtPaint.Text);
            decWheels = Convert.ToDecimal(txtWheels.Text);

            decStateAndLocalTaxes = Convert.ToDecimal(txtStateAndLocalTaxes.Text);
            decFederalTaxes = Convert.ToDecimal(txtFederalTaxes.Text);
            decLicensing = Convert.ToDecimal(txtLicensing.Text);

            decTotalOptions = decAC + decPaint + decWheels;
            lblTotalOptions.Text = decTotalOptions.ToString("c");

            decTotalTaxes = decStateAndLocalTaxes + decFederalTaxes + decLicensing;
            lblTotalTaxAndLicensing.Text = decTotalTaxes.ToString("c");

            decGrandTotal = decBasePrice + decTotalOptions + decTotalTaxes;
            lblGrandTotal.Text = decGrandTotal.ToString("c");

            strSummary = "Model: " + strModel + "\n" +
                "Year: " + strYear + "\n" +
                "Base Price: " + decBasePrice.ToString("c") + "\n" +
                "Total Options: " + decTotalOptions.ToString("c") + "\n" +
                "Total Taxes: " + decTotalTaxes.ToString("c") + "\n" +
                "Grand Total: " + decGrandTotal.ToString("c");
            lblSummary.Text = strSummary;

        }
    }
}
