using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace inheritance.product
{
    class product
    {
        public string name { get; set; }
        public double price { get; set; }

        public product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public product()
        {

        }

        public virtual string priceTag()
        {

            return name+ " $ " + price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
