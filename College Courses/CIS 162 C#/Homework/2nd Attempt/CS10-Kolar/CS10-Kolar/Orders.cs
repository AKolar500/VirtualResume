using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS10_Kolar
{
    class Orders
    {
        private string cstrDescription;
        private int cintQuantity;
        private decimal cdecPrice;
        private decimal cdecExtension;

        public Orders()
        {
        }

        public Orders(string strDescription, int intQuantity, decimal decPrice, decimal decExtension)
        {
            Description = strDescription;
            Quantity = intQuantity;
            Price = decPrice;
            Extension = decExtension;
        }

        public string Description
        {
            get { return cstrDescription; }
            set { cstrDescription = value; }
        }

        public int Quantity
        {
            get { return cintQuantity; }
            set { cintQuantity = value; }
        }

        public decimal Price
        {
            get { return cdecPrice; }
            set { cdecPrice = value; }
        }

        public decimal Extension
        {
            get { return cdecExtension; }
            set { cdecExtension = value; }
        }

        public decimal TotalPrice()
        {
            decimal decTotalPrice = 0;

            //objOrders.ExtensionPrice();
            decTotalPrice += ExtensionPrice();

            return decTotalPrice;
        }

        //public decimal TotalPrice()
        //{
        //    decimal decTotalPrice;

        //    for (int i = 0; i < colOrders.length; i++)
        //    {
        //    decTotalPrice = Price;
        //    }

        //    return decTotalPrice;
        //}

        public decimal ExtensionPrice()
        {

            //foreach (Orders objOrders in colOrders)
           // {
                Extension = Quantity * Price;
           // }
            return Extension;
        }

        public override string ToString()
        {
            string strOrderLine;

            strOrderLine = "\t" + Description +
                         "\t\t" + Quantity.ToString("n0") +
                         "\t\t" + Price.ToString("c") +
                         "\t\t" + ExtensionPrice().ToString("c");
            return strOrderLine;
        }
    }
}
