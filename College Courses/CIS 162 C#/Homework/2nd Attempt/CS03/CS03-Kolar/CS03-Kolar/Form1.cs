/*Alex Kolar
 * 2/4/2013
 * CIS162AD 29153
 * CS03
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS03_Kolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strFirstName, strLastName;

            decimal decWages, decDeductions, decGrossIncome;

            decimal decTaxRate;
            decimal decTaxesDue;
            decimal decFederalIncomeTax, decFirstTime, decTotalPayments;

            decimal decTotalDue;

            string strSummary;

            strFirstName = txtFirstName.Text;
            strLastName = txtLastName.Text;

            decWages = Convert.ToDecimal(txtWages.Text);
            decDeductions = Convert.ToDecimal(txtDeductions.Text);
            
            decGrossIncome = decWages - decDeductions;
            lblGrossIncome.Text = decGrossIncome.ToString("c");

            decTaxRate = Convert.ToDecimal(txtTaxRate.Text);
            
            //Tax calculation
            decTaxesDue = decGrossIncome * (decTaxRate / 100);
            lblTaxesDue.Text = decTaxesDue.ToString("c");

            decFederalIncomeTax = Convert.ToDecimal(txtFederalIncomeTaxWithheld.Text);
            decFirstTime = Convert.ToDecimal(txtFirstTimeHomeBuyer.Text);

            decTotalPayments = decFederalIncomeTax + decFirstTime;
            lblTotalPayments.Text = decTotalPayments.ToString("c");

            decTotalDue = decTaxesDue - decTotalPayments;
            lblTotalAmountDue.Text = decTotalDue.ToString("c");

            //Summary label code
            strSummary = "Name: " + strFirstName + " " + strLastName + Environment.NewLine +
                            "Gross Income: " + decGrossIncome.ToString("c") + Environment.NewLine +
                            "Total Taxes: " + decTaxesDue.ToString("c") + Environment.NewLine +
                            "Payments: " + decTotalPayments.ToString("c") + Environment.NewLine +
                            "Grand Total: " + decTotalDue.ToString("c");
            lblSummary.Text = strSummary;
        }
    }
}
