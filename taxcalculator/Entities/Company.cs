using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace taxcalculator.Entities
{
    class Company : People
    {
        public int NumberEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double totalTaxes()
        {
            if (NumberEmployees > 10)
            {
                double total = AnualIncome * 0.14;
                return total;            
            }
            else
            {
                double total = AnualIncome * 0.16;
                return total;
            }
        }
        public override string ToString()
        {
            return Name
                    + ": $ "
                    + totalTaxes().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
