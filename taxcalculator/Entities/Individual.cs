using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace taxcalculator.Entities
{
    class Individual : People
    {

        public double HelthExpendures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double helthExpendures) : base (name, anualIncome)
        {
            HelthExpendures = helthExpendures;
        }

        public override double totalTaxes()
        {
            if(AnualIncome >= 20000)
            {
                if(HelthExpendures > 0)
                {
                    double total = AnualIncome * 0.25;
                    double discount = HelthExpendures * 0.50;

                    return total - discount;
                }
                else
                {
                    double total = AnualIncome * 0.25;
                    return total;
                }
            }
            else
            {
                if (HelthExpendures > 0)
                {
                    double total = AnualIncome * 0.15;
                    double discount = HelthExpendures * 0.50;

                    return total - discount;
                }
                else
                {
                    double total = AnualIncome * 0.15;
                    return total;
                }
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
