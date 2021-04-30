using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic09
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void btnValidateFunction_Click(object sender, EventArgs e)
        {
            int intNumerator, intDenominator;
            decimal decDecimal;

            try
            {
                if (isValidData())
                {
                    intNumerator = int.Parse(txtNumerator.Text);
                    intDenominator = int.Parse(txtDenominator.Text);

                    decDecimal = (decimal)intNumerator / intDenominator;

                    lblDecimal.Text = decDecimal.ToString();
                }
   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private bool isValidData()
        {
            return isInt32(txtNumerator, "Numerator") &&
                    isInt32(txtDenominator, "Denominator");

        }
        public bool isInt32(TextBox txtTextBox, string strName)
        {
            try
            {
                Int32.Parse(txtTextBox.Text);
                return true;
            }
            catch (FormatException)
            {
                
                MessageBox.Show(strName + " must be an integer");
                txtTextBox.Focus();
                return false;
            }
        
        }

    }
}
