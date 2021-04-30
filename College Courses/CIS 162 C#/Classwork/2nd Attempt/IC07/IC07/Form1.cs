using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IC07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declare things
        decimal[] aryTimes = new decimal[100];
        int cintNextElement = 0;

        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal decTime;

            if (ValidateForm())
            {
                decimal.TryParse(txtTime.Text, out decTime);
                StoreTime(decTime);
                DisplayTimes();
            }
 
        }
        private decimal GetFastestTime()
        {
            decimal decFastestTime = decimal.MaxValue;

            for (int i = 0; i < cintNextElement; i++)
            {
                if (aryTimes[i] < decFastestTime)
                {
                    decFastestTime = aryTimes[i];
                }
            }

            return decFastestTime;
        }
        private void DisplayTimes()
        {
            lstTimes.Items.Clear();

            lstTimes.Items.Add("Fastest Time: " + GetFastestTime());

            txtTime.Text = "";
            txtTime.Focus();

            for (int i = 0; i < cintNextElement; i++)
            {
                lstTimes.Items.Add(aryTimes[i]);
            }
        }
        private void StoreTime(decimal decTime)
        {
            aryTimes[cintNextElement] = decTime;
            cintNextElement++;
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
