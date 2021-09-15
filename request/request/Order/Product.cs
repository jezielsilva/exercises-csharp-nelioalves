using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace request.Order
{
    class Product
    {
        public String name { get; set; }
        public Double price { get; set; }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public Product()
        {

        }
    }
}
