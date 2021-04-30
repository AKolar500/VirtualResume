/*Programmer: Alex Kolar
 * Course: CIS162 Section 28026
 * Date: 2/23/2012
 * Program: CS03
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS03
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
            decimal decTaxRate, decTaxesDue;
            decimal decFederal, decFirstTime, decPayments;
            decimal decGrandTotal;

            string strSummary;

            //Name Box Operations
            strFirstName = Convert.ToString(txtFirstName.Text);
            strLastName = Convert.ToString(txtLastName.Text);

            //Income Box Operations
            decWages = Convert.ToDecimal(txtWages.Text);
            decDeductions = Convert.ToDecimal(txtDeductions.Text);
            decGrossIncome = decWages - decDeductions;
            lblGrossIncome.Text = decGrossIncome.ToString();

            //Taxes Box Operations
            decTaxRate = Convert.ToDecimal(txtTaxRate.Text);
            decTaxesDue = decTaxRate * decGrossIncome;
            lblTaxesDue.Text = decTaxesDue.ToString();

            //Payments Box Operations
            decFederal = Convert.ToDecimal(txtFederal.Text);
            decFirstTime = Convert.ToDecimal(txtFirstTime.Text);
            decPayments = decFederal + decFirstTime;
            lblPayments.Text = decPayments.ToString();

            //Grand Total Operations
            decGrandTotal = decTaxesDue - decPayments;
            lblGrandTotal.Text = decGrandTotal.ToString();

            //format and display summary sheet 
            strSummary = "Name: " + strFirstName + " " + strLastName + Environment.NewLine +
                            "Gross Income: " + decGrossIncome.ToString("c") + Environment.NewLine +
                            "Total Taxes: " + decTaxesDue.ToString("c") + Environment.NewLine +
                            "Payments: " + decPayments.ToString("c") + Environment.NewLine +
                            "Grand Total: " + decGrandTotal.ToString("c");
            lblSummary.Text = strSummary;
        }
    }
}
