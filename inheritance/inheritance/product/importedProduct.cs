using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace inheritance.product
{
    class importedProduct : product
    {
        public double customsFee { get; set; }

        public importedProduct()
        {

        }

        public importedProduct(string name, double price, double customsFee): base(name, price)
        {
            this.customsFee = customsFee;
        }

        public override string priceTag()
        {

            return name + " $ " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + "(Customs fee: $ " + customsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double totalPrice()
        {
            return customsFee + price;
        }
    }
}
