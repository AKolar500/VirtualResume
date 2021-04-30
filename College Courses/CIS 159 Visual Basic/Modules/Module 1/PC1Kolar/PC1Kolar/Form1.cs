/* Programmer: Alex Kolar
 * Date: 1/20/2013
 * Class: CIS 159 28998
 * Program Name: Carpet Size
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Allows the user to input values into the Length and Width fields.
            txtLength.Text = txtLength.ToString();
            txtWidth.Text = txtWidth.ToString();
           
            //Operation for Area
            //txtArea.Text = txtLength * txtWidth;

        }
    }
}
