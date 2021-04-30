using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic08_032013
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

        decimal[] aryWarranty_Bracket = new decimal[] { 20000, 50000, 100000, 500000 };
        decimal[] aryWarranty_1_Year = new decimal[] { 1000, 5000, 10000, 50000 };
        decimal[] aryWarranty_3_Years = new decimal[] { 2000, 10000, 20000, 100000 };
        
        decimal[,] aryWarranty = new decimal[,] {{ 20000, 50000, 100000, 500000 },
                                                         { 0, 0, 0, 0 }, 
                                                         { 1000, 5000, 10000, 50000 }, 
                                                        { 2000, 10000, 20000, 100000 }};
        


        const decimal BASE_PRICE_BRACKET_1 = 10000;
        const decimal STATE_AND_LOCAL_TAXES_1 = 500;
        const decimal FEDERAL_TAXES_1 = 300;
        const decimal LICENSING_1 = 350;

        const decimal BASE_PRICE_BRACKET_2 = 20000;
        const decimal STATE_AND_LOCAL_TAXES_2 = 1000;
        const decimal FEDERAL_TAXES_2 = 600;
        const decimal LICENSING_2 = 700;


        const decimal STATE_AND_LOCAL_TAXES_3 = 2000;
        const decimal FEDERAL_TAXES_3 = 1200;
        const decimal LICENSING_3 = 1400;

        decimal decGrandTotal;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strModel, strYear;
            decimal decBasePrice;

            decimal decAC, decPaint, decWheels;
            decimal decTotalOptions = 0;
            decimal decExtendedWarranty;
            int intExtendedWarrantyType;

            decimal decStateAndLocalTaxes, decFederalTaxes, decLicensing;
            decimal decTotalTaxAndLicensing;

            decimal decDummy;

            string strSummary;

            if (ValidateData())
            {
  
                strModel = txtModel.Text;
                strYear = txtYear.Text;

                decBasePrice = Convert.ToDecimal(txtBasePrice.Text);

                decTotalOptions = TotalOptions();

                decTotalOptions = TotalOption2(decTotalOptions);
 

                lblTotalOptions.Text = decTotalOptions.ToString("c");



                intExtendedWarrantyType = ExtendedWarrantyType();
                decExtendedWarranty = ExtendedWarranty_old(intExtendedWarrantyType, decBasePrice);
               // decExtendedWarranty = ExtendedWarranty(intExtendedWarrantyType, decBasePrice);

                 lblExtendedWarranty.Text = decExtendedWarranty.ToString("c");

                 Taxes(decBasePrice, out decStateAndLocalTaxes, out decFederalTaxes, out decLicensing);

                txtStateAndLocalTaxes.Text = decStateAndLocalTaxes.ToString("c");
                txtFederalTaxes.Text = decFederalTaxes.ToString("c");
                txtLicensing.Text = decLicensing.ToString("c");

                decTotalTaxAndLicensing = decStateAndLocalTaxes + decFederalTaxes + decLicensing;

                lblTotalTaxAndLicensing.Text = decTotalTaxAndLicensing.ToString("c");

                decGrandTotal = GrandTotal(decBasePrice, decTotalOptions, decExtendedWarranty, decTotalTaxAndLicensing);
                //decGrandTotal = decBasePrice + decTotalOptions + decExtendedWarranty + decTotalTaxAndLicensing;
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
 
        }

        private decimal TotalOption2(decimal decTotalOptions)
        {
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
            return decTotalOptions;
        }

        private decimal GrandTotal(decimal decBasePrice, decimal decTotalOptions, decimal decExtendedWarranty, decimal decTotalTaxAndLicensing)
        {
            decimal decGrandTotal;

            decGrandTotal = decBasePrice + decTotalOptions + decExtendedWarranty + decTotalTaxAndLicensing;

            return decGrandTotal;

        }

        private void Taxes(decimal xxx, out decimal decStateAndLocalTaxes, out decimal decFederalTaxes, out decimal decLicensing)
        {

            if (xxx <= BASE_PRICE_BRACKET_1)
            {
                decStateAndLocalTaxes = STATE_AND_LOCAL_TAXES_1;
                decFederalTaxes = FEDERAL_TAXES_1;
                decLicensing = LICENSING_1;
            }
            else if (xxx <= BASE_PRICE_BRACKET_2)
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

        }

        private int ExtendedWarrantyType()
        {
            int intExtendedWarrantyType;

            if (rad1Year.Checked)
            {
                intExtendedWarrantyType = 2;
            }
            else if (rad3Years.Checked)
            {
                intExtendedWarrantyType = 3;
            }
            else
            {
                intExtendedWarrantyType = 1;
            }
            return intExtendedWarrantyType;


        }
        private decimal ExtendedWarranty(int intExtendedWarrantyType, decimal decBasePrice)
        {
            decimal decExtendedWarranty = 0;

            for (int i = 0; i < aryWarranty.GetLength(1); i++)
            {
                if (decBasePrice <= aryWarranty[0, i])
                {
                        decExtendedWarranty = aryWarranty[intExtendedWarrantyType, i];

                    break;
                }
            }

            return decExtendedWarranty;
        }
        private decimal ExtendedWarranty_old(int intExtendedWarrantyType, decimal decBasePrice)
        {
            decimal decExtendedWarranty = 0;

            for (int i = 0; i < aryWarranty_Bracket.Length; i++)
            {
                if (decBasePrice <= aryWarranty_Bracket[i])
                {
                    if (intExtendedWarrantyType == 2)
                    {
                        decExtendedWarranty = aryWarranty_1_Year[i];
                    }
                    else if (intExtendedWarrantyType == 3)
                    {
                        decExtendedWarranty = aryWarranty_3_Years[i];
                    }
                    else
                    {
                        decExtendedWarranty = 0;
                    }

                    break;
                }

            }
            
            return decExtendedWarranty;

        }

        private decimal TotalOptions()
        {
            decimal decTotalOptions = 0;

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

            return decTotalOptions;
        }


        private bool ValidateData()
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
                        MessageBox.Show("Error:Base Price is not numeric");
                        txtBasePrice.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error:Year is Blank");
                    txtYear.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error:Model is Blank");
                txtModel.Focus();
            }



            return isValid;
        }


        private void btnFinance_Click(object sender, EventArgs e)
        {
            //Form2 frmForm2 = new Form2(decGrandTotal);

            // frmForm2.ShowDialog();

        }





    }
}
