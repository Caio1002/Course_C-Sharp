using PrimProj.Entities;
using PrimProj.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace PrimProj
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 500.0));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 0.01));

            double sum = 0.0;

            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach(Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}