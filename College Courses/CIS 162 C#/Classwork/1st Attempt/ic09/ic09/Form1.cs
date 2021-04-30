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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNoExceptionHandling_Click(object sender, EventArgs e)
        {
            int intNumerator, intDenominator;
            decimal decDecimal;

            intNumerator = int.Parse(txtNumerator.Text);
            intDenominator = int.Parse(txtDenominator.Text);

            decDecimal = (decimal)intNumerator / intDenominator;

            lblDecimal.Text = decDecimal.ToString();


        }

        private void btnJustException_Click(object sender, EventArgs e)
        {
            int intNumerator, intDenominator;
            decimal decDecimal;

            try
            {
                intNumerator = int.Parse(txtNumerator.Text);
                intDenominator = int.Parse(txtDenominator.Text);

                decDecimal = (decimal)intNumerator / intDenominator;

                lblDecimal.Text = decDecimal.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

 
        }

        private void btnSeveralExceptions_Click(object sender, EventArgs e)
        {
            int intNumerator, intDenominator;
            decimal decDecimal;

            try
            {
                intNumerator = int.Parse(txtNumerator.Text);
                intDenominator = int.Parse(txtDenominator.Text);

                decDecimal = (decimal)intNumerator / intDenominator;

                lblDecimal.Text = decDecimal.ToString();
            }

            catch (FormatException ex)
            {
               
                MessageBox.Show(ex + "Not a Valid Number");

            }
            catch (OverflowException)
            {

                MessageBox.Show("Number Too Big");

            }

            
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnNestedExceptions_Click(object sender, EventArgs e)
        {
            int intNumerator, intDenominator;
            decimal decDecimal;

            try
            {
                intNumerator = int.Parse(txtNumerator.Text);
                try
                {
                    intDenominator = int.Parse(txtDenominator.Text);
                    try
                    {
                        decDecimal = (decimal)intNumerator / intDenominator;

                        lblDecimal.Text = decDecimal.ToString();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
   
                }
                catch (Exception)
                {
                    
                    throw;
                }
  
            }

             catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
    }
}
