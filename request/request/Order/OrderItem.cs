using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace request.Order
{
    class OrderItem
    {
        public int quantify { get; set; }
        public double price { get; set; }
        public Product Product { get; set; }

        public Double subTotal()
        {
            Double subTotal = price * quantify;
            return subTotal;
        }

        public OrderItem()
        {

        }

        public OrderItem(int quantify, double price, Product product)
        {
            this.quantify = quantify;
            this.price = price;
            this.Product = product;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Product.name+", $"+price.ToString("F2", CultureInfo.InvariantCulture)+
                ", Quantity: "+quantify+", SubTotal: $"+subTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
