using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic11
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

            try
            {
                intNumerator = int.Parse(txtNumerator.Text);
                intDenominator = int.Parse(txtDenominator.Text);

                decDecimal = (decimal)intNumerator / intDenominator;

                lblDecimal.Text = decDecimal.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Critical Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            }
            finally
            {
            }
        }
    }
}
