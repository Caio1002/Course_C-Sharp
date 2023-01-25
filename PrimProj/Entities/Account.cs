using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimProj.Entities
{
    abstract class Account
    {
        /*
           MAIN
           Account acc = new Account(1001, "Alex", 0.0);
           BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

           //Upcasting
           Account acc1 = bacc;
           Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
           Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

           //Downcasting
           BusinessAccount acc4 = (BusinessAccount)acc2;
           acc4.Loan(100.0);

           //testes
           if (acc3 is BusinessAccount)
           {
               //SINTAXE ALTERNATIVA
               //BusinessAccount acc5 = acc3 as BusinessAccount;
               BusinessAccount acc5 = (BusinessAccount)acc3;
               acc5.Loan(200.0);
               Console.WriteLine("Loan!");
           }
           if (acc3 is SavingsAccount)
           {
               SavingsAccount acc5 = (SavingsAccount)acc3;
               acc5.UpdateBalance();
               Console.WriteLine("Update!");
           }
           */

        /*
         * ABSTRACT
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
            */

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }


        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;//5.0 = taxa
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
