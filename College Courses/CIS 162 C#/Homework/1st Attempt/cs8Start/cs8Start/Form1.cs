/*programmer: John Corker & Alex Kolar
 *program: cs08 
 * Date: 3.7.11-3/28/2012
 * class:cis162ad
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs08
{
    public partial class Form1 : Form
    {
        const decimal decBAGEL_PRICE = .50m;
        const decimal decTAX_RATE = .10m;
        decimal decSubtotal, decTotal;
           
        public Form1()
        { 
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
 
            int intSesameQty, intPoppyTotal, intRaisinTotal;
            decimal decSesameTotal = 0;
            decimal decPoppyTotal = 0;
            decimal decRaisinTotal = 0;
            decimal decTaxes;

            if (validateData()) 
            { 
                if (chkSesame.Checked)
                {
                    intSesameQty = Convert.ToInt32(txtSesameQty.Text);
                    decSesameTotal = intSesameQty * decBAGEL_PRICE;
                    lblSesameSeedTotal.Text = decSesameTotal.ToString("c");
                }
                if (chkPoppy.Checked) 
                {
                    intPoppyTotal = Convert.ToInt32(txtPoppyQty.Text);
                    decPoppyTotal = intPoppyTotal * decBAGEL_PRICE;
                    lblPoppyTotal.Text = decPoppyTotal.ToString("c");
                }
                if (chkRaisin.Checked)
                {
                    intRaisinTotal = Convert.ToInt32(txtRaisinQty.Text);
                    decRaisinTotal = intRaisinTotal * decBAGEL_PRICE;
                    lblRaisinTotal.Text = decRaisinTotal.ToString("c");
                }

                decSubtotal = decSesameTotal + decPoppyTotal + decRaisinTotal;
                lblSubtotal.Text = decSubtotal.ToString("c");

                decTaxes = decSubtotal * decTAX_RATE;

                decTotal = decSubtotal + decTaxes;

                lblTaxes.Text = decTaxes.ToString("c");
                lblSubtotal.Text = decSubtotal.ToString("c");
                lblTotal.Text = decTotal.ToString("c");

            }

 
        }


        private bool validateData()
        {
            int intDummy;
            
            bool isValid = false;

            if (!chkSesame.Checked && !chkPoppy.Checked && !chkRaisin.Checked)
            {
                MessageBox.Show("No Bagels Checked");

            }
            else
                if (chkSesame.Checked && !int.TryParse(txtSesameQty.Text, out intDummy))
                {
                    MessageBox.Show("error on txtSesameQty");
                    txtSesameQty.Focus();
                    txtSesameQty.SelectAll();
                   
                }
                else
                    if (chkPoppy.Checked && !int.TryParse(txtPoppyQty.Text, out intDummy))
                    {
                        MessageBox.Show("error on txtPoppyQty");
                        txtPoppyQty.Focus();
                        txtPoppyQty.SelectAll();
                    }
                    
                    else
                       if (chkRaisin.Checked && !int.TryParse(txtRaisinQty.Text, out intDummy))
                       {
                            MessageBox.Show("error on txtRaisinQty");
                            txtRaisinQty.Focus();
                            txtRaisinQty.SelectAll();
                       }
                       else
                           isValid = true;
                      
            return isValid;
        }        





        
        private void chkSesame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSesame.Checked)
            {
                txtSesameQty.Enabled = true;
                txtSesameQty.Focus();
            }
            else
            {
                txtSesameQty.Enabled = false;
                txtSesameQty.Text = "";
                lblSesameSeedTotal.Text = "";
            }

        }

        private void chkPoppy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPoppy.Checked)
            {
                txtPoppyQty.Enabled = true;
                txtPoppyQty.Focus();
            }
            else
            {
                txtPoppyQty.Enabled = false;
                txtPoppyQty.Text = "";
                lblPoppyTotal.Text = "";
            }
        }

        private void chkRaisin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRaisin.Checked)
            {
                txtRaisinQty.Enabled = true;
                txtRaisinQty.Focus();
 
            }
            else
            {
                txtRaisinQty.Enabled = false;
                txtRaisinQty.Text = "";
                lblRaisinTotal.Text = "";
            }
           
        }

          private void btnClear_Click(object sender, EventArgs e)
        {
            chkSesame.Checked = false;
            chkPoppy.Checked = false;
            chkRaisin.Checked = false;



            lblSubtotal.Text = "";
            lblTaxes.Text = "";
            lblTotal.Text = "";


        }

          private void Form1_Load(object sender, EventArgs e)
          {
              
              chkSesame_CheckedChanged(sender, e);
              chkPoppy_CheckedChanged(sender, e);
              chkRaisin_CheckedChanged(sender, e);
    
          }
 
    }
}
