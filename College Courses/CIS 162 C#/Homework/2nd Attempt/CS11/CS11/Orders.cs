using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS11
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
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Description is empty. You naughty boy.");
                }
                cstrDescription = value;
            }
        }

        public int Quantity
        {
            get { return cintQuantity; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Quantity <= 0. Either buy something or get out.");
                }
                cintQuantity = value;
            }
        }

        public decimal Price
        {
            get { return cdecPrice; }
            set {
                if (value <= 0)
                {
                    throw new Exception("Price <= 0. This is Scrooge corp.\nWe can't give things away for free.");
                }
                cdecPrice = value;
            }
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
