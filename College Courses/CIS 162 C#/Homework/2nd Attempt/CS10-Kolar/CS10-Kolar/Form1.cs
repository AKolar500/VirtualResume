/*Alex Kolar
 * 4/17/2013
 * CIS162AD Section 29153
 * CS10 - Class-Based Programming
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CS10_Kolar
{
    public partial class Form1 : Form
    {
        List<Orders> colOrders = new List<Orders>();
        decimal decExtension = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strDescription;
            int intQuantity;
            decimal decPrice;


            if (validateForm())
            {
                strDescription = txtDescription.Text;
                intQuantity = int.Parse(txtQuantity.Text);
                decPrice = decimal.Parse(txtPrice.Text);

                addOrder(strDescription, intQuantity, decPrice);

                loadOrdersListBox();

                lblTotal.Text = getTotalPrice().ToString("c");
            }
        }

        //used as middle-man between the label's display and the TotalPrice() method, which is in the Orders class.
        public decimal getTotalPrice()
        {
            decimal decGTotalPrice = 0;

            foreach (Orders objOrders in colOrders)
            {
                decGTotalPrice += objOrders.TotalPrice();
            }

            return decGTotalPrice;
        }

        //public decimal TotalPrice()
        //{
        //    decimal decTotalPrice = 0;

        //    foreach (Orders objOrders in colOrders)
        //    {
        //        //objOrders.ExtensionPrice();
        //        decTotalPrice += decExtension;
        //        lblTotal.Text = decTotalPrice.ToString("c");
        //    }

        //    return decTotalPrice;
        //}

        //public decimal TotalPrice()
        //{
        //    decimal decTotalPrice;

        //    foreach (Orders objOrders in colOrders)
        //    {
                
        //    }

        //    return decTotalPrice;
        //}

        //Prepare the collection to accept new input from the user.
        private void loadOrdersListBox()
        {
            lstOrder.Items.Clear();

            //add the input from the user to the collection
            foreach (Orders objOrders in colOrders)
            {
                lstOrder.Items.Add(objOrders);
            }
        }

        //validates all data
        private bool validateForm()
        {
            bool isValid = false;
            int intDummy;
            decimal decDummy;

            if (txtDescription.Text != "")
            {
                if (int.TryParse(txtQuantity.Text, out intDummy))
                {
                    if (decimal.TryParse(txtPrice.Text, out decDummy))
                    {
                        isValid = true;
                    }
                    else
                    {
                        MessageBox.Show("Error: Price not Decimal");
                        txtQuantity.Text = "";
                        txtQuantity.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error: Quantity not Integer");
                    txtPrice.Text = "";
                    txtPrice.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error: Description is Empty");
                txtDescription.Text = "";
                txtDescription.Focus();
            }
            return isValid;
        }

        public void addOrder(string strDescription, int intQuantity, decimal decPrice)
        {
            Orders objOrders = new Orders(strDescription, intQuantity, decPrice, decExtension);

            colOrders.Add(objOrders);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();

            txtDescription.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            txtDescription.Focus();
        }
    }
}
