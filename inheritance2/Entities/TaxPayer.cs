using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace inheritance2.Entities
{
    abstract class TaxPayer
    {
        public string name { get; set; }
        public double anualIncome { get; set; }
        
        public TaxPayer()
        {

        }

        public TaxPayer(string name, double anualIncome)
        {
            this.name = name;
            this.anualIncome = anualIncome;
        }

        public abstract double tax();

        public virtual string ToString()
        {
            return name;
        }

    }
}
