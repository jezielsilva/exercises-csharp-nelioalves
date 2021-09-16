using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace inheritance2.Entities
{
    class Company : TaxPayer
    {
        public int numberOfEmployees { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualIncome, int numberOfEmployees)
        {
            this.numberOfEmployees = numberOfEmployees;
            this.name = name;
            this.anualIncome = anualIncome;
        }

        public override double tax()
        {
            double tax = 0;
            if(numberOfEmployees < 10)
            {
                tax = anualIncome * 0.16;
            }
            else
            {
                tax = anualIncome * 0.14;
            }
            return tax;
        }

        public override string ToString()
        {
            return base.ToString() + " $ " + tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
