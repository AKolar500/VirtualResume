/*Alex Kolar
 * 5/1/2013
 * CIS162AD Section 29153
 * CS11 - Exceptions
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

namespace CS11
{
    public partial class Form1 : Form
    {
        List<Orders> colOrders = new List<Orders>();
        Orders objCurrentOrder;

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

            try
            {
                if (validateForm())
                {
                    strDescription = txtDescription.Text;
                    intQuantity = int.Parse(txtQuantity.Text);
                    decPrice = decimal.Parse(txtPrice.Text);

                    addOrder(strDescription, intQuantity, decPrice);

                    loadOrdersListBox();

                    clearTextBoxes();

                    lblTotal.Text = getTotalPrice().ToString("c");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Critical Error:\n" + ex.Message + "\nHeart Attack!");
            }

        }

        public void clearTextBoxes()
        {
            txtDescription.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
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
            // bool isValid = false;
            int intDummy;
            decimal decDummy;

            //if (txtDescription.Text != "")
            //{
            //    if (int.TryParse(txtQuantity.Text, out intDummy))
            //    {
            //        if (decimal.TryParse(txtPrice.Text, out decDummy))
            //        {
            //            isValid = true;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error: Price not Decimal");
            //            txtQuantity.Text = "";
            //            txtQuantity.Focus();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error: Quantity not Integer");
            //        txtPrice.Text = "";
            //        txtPrice.Focus();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Error: Description is Empty");
            //    txtDescription.Text = "";
            //    txtDescription.Focus();
            //}
            if (txtDescription.Text != "")
            {
                try
                {
                    int.Parse(txtQuantity.Text);
                    try
                    {
                        decimal.Parse(txtPrice.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error: Price not Positive Decimal");
                        txtPrice.Focus();
                        txtPrice.SelectAll();

                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Quantity not Positive Integer");
                    txtQuantity.Focus();
                    txtQuantity.SelectAll();

                    return false;
                }
            }

            return true;
        }

        public void addOrder(string strDescription, int intQuantity, decimal decPrice)
        {
            Orders objOrders = new Orders(strDescription, intQuantity, decPrice, decExtension);

            colOrders.Add(objOrders);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();

            clearTextBoxes();

            txtDescription.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm())
                {
                    objCurrentOrder.Description = txtDescription.Text;
                    objCurrentOrder.Quantity = int.Parse(txtQuantity.Text);
                    objCurrentOrder.Price = decimal.Parse(txtPrice.Text);

                    loadOrdersListBox();
                    clearTextBoxes();
                    lblTotal.Text = getTotalPrice().ToString("c");

                    btnAdd.Enabled = true;

                    txtDescription.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Critical Error:\n" + ex.Message + "\nStroke!");
            }
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            objCurrentOrder = colOrders[lstOrder.SelectedIndex];

            txtDescription.Text = objCurrentOrder.Description;
            txtQuantity.Text = objCurrentOrder.Quantity.ToString();
            txtPrice.Text = objCurrentOrder.Price.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }
    }
}
