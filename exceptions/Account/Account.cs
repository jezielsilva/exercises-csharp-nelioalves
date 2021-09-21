using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using exceptions.Exceptions;

namespace exceptions.Account
{
    class Account : ApplicationException
    {
        public int number { get; set; }
        public string holder { get; set; }
        public double balance { get; set; }
        public double withdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
            this.withdrawLimit = withdrawLimit;
        }

        public Account()
        {

        }

        public void deposit(double amount)
        {
            balance += amount;
        }

        public void withdraw(double amount)
        {
            if(amount > withdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine();
                Console.WriteLine($"New Balance: {balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
