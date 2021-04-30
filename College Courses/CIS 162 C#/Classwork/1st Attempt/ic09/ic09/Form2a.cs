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
    public partial class Form2a: Form
    {
        public Form2a()
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
            bool isValid = false;

 
            int.Parse(txtNumerator.Text);
                
            int.Parse(txtDenominator.Text);
            
            isValid = true;
            return isValid;
        }

    }
}
