using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic07a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal[] caryTimes = new decimal[100];//the c in cary says it's at the class level
        int cintNextElement = 0;

        private void btnOK_Click(object sender, EventArgs e)
        {
            decimal decTime;

            if (decimal.TryParse(txtTime.Text, out decTime))
            {
                LoadArray(decTime);
                LoadListbox();
                lstTimes.Items.Add("Fastest Time: " + GetFastestTime() + "Seconds");
                lstTimes.Items.Add("Slowest Time: " + GetSlowestTime() + "Seconds");


                //caryTimes[cintNextElement] = decTime;
                //cintNextElement++;
            }
            else
	        {
                MessageBox.Show("Error on Time");
                txtTime.Focus();
	        }
        }
        private void LoadArray(decimal decTime)
        {
            caryTimes[cintNextElement] = decTime;
            cintNextElement++;
        }
        private void LoadListbox()
        {
            lstTimes.Items.Clear();

            for (int i = 0; i < cintNextElement; i++)
            {
                lstTimes.Items.Add(caryTimes[i]);
            }
        }
        private decimal GetFastestTime()
        {
            decimal decFastestTime = decimal.MaxValue;

            for (int i = 0; i < cintNextElement; i++)
            {
                if (caryTimes[i] < decFastestTime)
                {
                    decFastestTime = caryTimes[i];
                }
            }
            return decFastestTime;
        }
        private decimal GetSlowestTime()
        {
            decimal decSlowestTime = decimal.MinValue;

            for (int i = 0; i < cintNextElement; i++)
            {
                if (caryTimes[i] > decSlowestTime)
                {
                    decSlowestTime = caryTimes[i];
                }
            }
            return decSlowestTime;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cintNextElement = 0;
            lstTimes.Items.Clear();
        }
    }
}
