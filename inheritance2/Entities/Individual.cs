using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace inheritance2.Entities
{
    class Individual : TaxPayer
    {
        public double healthExpenditures { get; set; }

        public Individual()
        {

        }

        public Individual(string name, double anualIncome,double healthExpenditures)
        {
            this.healthExpenditures = healthExpenditures;
            this.name = name;
            this.anualIncome = anualIncome;
        }

        public override double tax()
        {
            double tax = 0;
            if(anualIncome < 20000)
            {
                tax = (anualIncome * 0.15) - (healthExpenditures * 0.50);
            }
            if(anualIncome > 20000)
            {
                tax = (anualIncome * 0.25) - (healthExpenditures * 0.50);
            }

            return tax;
        }
        public override string ToString()
        {
            return base.ToString() + " $ " + tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
