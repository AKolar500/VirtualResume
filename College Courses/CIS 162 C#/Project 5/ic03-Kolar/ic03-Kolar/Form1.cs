using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
            decimal decAC, decPaint, decWheels, decTotalOptions;
            decimal decStateAndLocal, decFederal, decLicensing, decTotalTaxes;
            decimal decGrandTotal;

            strModel = txtModel.Text;
            strYear = txtYear.Text;

            decBasePrice = Convert.ToDecimal(txtBasePrice.Text);
            decAC = Convert.ToDecimal(txtAC.Text);
            decPaint = Convert.ToDecimal(txtPaint.Text);
            decWheels = Convert.ToDecimal(txtWheels.Text);

            decTotalOptions = decAC + decPaint + decWheels;
            lblTotalOptions.Text = decTotalOptions.ToString("$.##");

            decStateAndLocal = Convert.ToDecimal(txtStateAndLocal.Text);
            decFederal = Convert.ToDecimal(txtFederal.Text);
            decLicensing = Convert.ToDecimal(txtLicensing.Text);

            decTotalTaxes = decStateAndLocal + decFederal + decLicensing;
            lblTotalTaxes.Text = decTotalTaxes.ToString("c");

            decGrandTotal = decBasePrice + decTotalOptions + decTotalTaxes;
            lblGrandTotal.Text = decGrandTotal.ToString("$.00");

            lblSummary.Text = "Model: " + strModel + "\n" + "Year: " + strYear + "\n" + "Base Price: "+
                decBasePrice.ToString("$.##") + "\n" + "Total Options: " + decTotalOptions.ToString("$.##") + "\n" + "Total Taxes: "
                + decTotalTaxes.ToString("c") + "\n" + "Grand Total: " + decGrandTotal.ToString("$.00");
        }
    }
}
