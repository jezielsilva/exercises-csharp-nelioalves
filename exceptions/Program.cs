using System;
using exceptions.Exceptions;
namespace exceptions.Account
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine());
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, balance, withdraw);
                account.withdraw(amount);
                
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
