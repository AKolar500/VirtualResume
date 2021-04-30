using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic07_101012a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal decTime;

            if (ValidateForm())
            {
                decimal.TryParse(txtTime.Text, out decTime);
            }
 
        }

        public bool ValidateForm()
        {
            decimal decDummy;

            bool isValid = false;

            if (decimal.TryParse(txtTime.Text, out decDummy))
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("error:txtTime");
                txtTime.Focus();
                txtTime.SelectAll();
            }


            return isValid;

        }
    }
}
