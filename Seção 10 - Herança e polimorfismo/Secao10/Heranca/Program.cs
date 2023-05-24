using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinesAccount account = new BussinesAccount(8010, "Bob Brown", 100.0, 500.00);

            Console.WriteLine(account.Balance);

            // account.Balance = 200.0;
        }
    }
}
