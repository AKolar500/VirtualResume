/*
 * Programmer: Alex Kolar
 * Program: CS01
 * Date: 01/16/2013
 * Class: CIS 162AD - 29153
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

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Hello World! My Name Is:";
            txtName.Text = "Alex Kolar";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
