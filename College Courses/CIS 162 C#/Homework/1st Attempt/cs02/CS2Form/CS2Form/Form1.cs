/* Alex Kolar
 * 1/24/2013
 * CIS162AD 29153
 * CS02
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS2_Kolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            lblDepartment.Text = "Customer Relations";
            lblContact.Text = "Tricia Smith";
            lblPhone.Text = "500-1111";
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            lblDepartment.Text = "Marketing";
            lblContact.Text = "Michelle Tyler";
            lblPhone.Text = "500-2222";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblDepartment.Text = "Order Processing";
            lblContact.Text = "Kenna Ross";
            lblPhone.Text = "500-3333";
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            lblDepartment.Text = "Shipping";
            lblContact.Text = "Eric Johnson";
            lblPhone.Text = "500-4444";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
