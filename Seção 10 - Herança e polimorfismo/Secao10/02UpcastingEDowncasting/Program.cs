using System;
using _02UpcastingEDowncasting.Entities;

namespace _02UpcastingEDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BussinesAccount bussinesAccount = new BussinesAccount(1001, "Maria", 0.0, 500.0);

            // UPCASTING 

            Account acc1 = bussinesAccount;
            Account acc2 = new BussinesAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1002, "Anna", 0.0, 0.01);

            // DOWNCASTING
            BussinesAccount acc4 =  (BussinesAccount)acc2;
            acc4.Loan(100.0);

            // BussinesAccount acc5 = (BussinesAccount)acc3; Ocorre erro
            if (acc3 is BussinesAccount)
            {
                //BussinesAccount acc5 = (BussinesAccount)acc3;
                BussinesAccount acc5 = acc3 as BussinesAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
