using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using taxcalculator.Entities;

namespace taxcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();

            Console.Write("Enter the number of tax payers: ");
            int payers = int.Parse(Console.ReadLine());        

            for(int i = 0; i < payers; i++)
            {
                Console.WriteLine("Tax payer #" + (i+1) + " data:");
                Console.Write("Individual or Company (i/c)");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anuel income: ");
                double value = double.Parse(Console.ReadLine());
                if(type == 'i')
                {
                    Console.Write("Helth expenditures: ");
                    double exp = double.Parse(Console.ReadLine());

                    Individual ind = new Individual(name, value, exp);

                    peoples.Add(ind);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());

                    Company comp = new Company(name, value, emp);

                    peoples.Add(comp);
                }                
            }

            Console.WriteLine("TAXES PAID:");

            double total = 0.0;

            foreach(People people in peoples)
            {
                Console.Write(people.ToString());

                total += people.totalTaxes();
            }
            Console.WriteLine("");

            Console.WriteLine("TOTAL TAXES: $" + total.ToString("F2", CultureInfo.InstalledUICulture));
        }
    }
}
