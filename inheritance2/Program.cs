using System;
using System.Collections.Generic;
using System.Globalization;

namespace inheritance2.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
 
            Console.Write("Enter the number of tax payers: ");
            int payers = int.Parse(Console.ReadLine());

            for(int i = 1; i<=payers; i++)
            {
                Console.WriteLine($"Tax payer {i} data: ");
                Console.Write("Individual or company (i/c)?");
                char letter = char.Parse(Console.ReadLine());
                if(letter == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income:");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures:");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income:");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees:");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberEmployees));
                }
            }
            double taxTotal = 0;
            Console.WriteLine("TAXES PAID: ");
            foreach(TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.name + ": $" + taxPayer.tax().ToString("F2", CultureInfo.InvariantCulture));
                taxTotal += taxPayer.tax();
            }
            Console.WriteLine($"TOTAL TAXES: $ {taxTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
