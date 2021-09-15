using System;
using System.Collections.Generic;

namespace inheritance.product
{
    class Program
    {
        static void Main(string[] args)
        {
            List <product> list= new List <product>();
            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 1; i<=number; i++)
            {
                Console.Write($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char letter = char.Parse(Console.ReadLine());
                if(letter == 'i')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Price:");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Customs fee:");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new importedProduct(name, price, customsFee));
                }
                if(letter == 'c')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Price:");
                    double price = double.Parse(Console.ReadLine());
                    list.Add(new product(name, price));
                }
                if(letter == 'u')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Price:");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new usedProduct(name, price, date));
                }
            }

            foreach(product emp in list)
            {
                Console.WriteLine(emp.priceTag());
            }
        }
    }
}
