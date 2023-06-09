﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03SobreposicaoVirtualOverrideBase.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        private readonly double Tax = 5.0;
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
            Balance -= amount + Tax;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
