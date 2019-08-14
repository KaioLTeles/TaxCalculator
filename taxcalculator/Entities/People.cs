using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxcalculator.Entities;

namespace taxcalculator.Entities
{
     abstract class  People
     {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public People()
        {

        }

        protected People(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double totalTaxes(); 

     }
}
