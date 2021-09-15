using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace inheritance.product
{
    class usedProduct : product
    {
        public DateTime manufactureDate { get; set; }

        public usedProduct(string name, double price, DateTime manufactureDate):base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public usedProduct()
        {

        }

        public override string priceTag()
        {
            return name + " (used) $" + price.ToString("F2", CultureInfo.InvariantCulture) + "(Manufacture date: " + manufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
