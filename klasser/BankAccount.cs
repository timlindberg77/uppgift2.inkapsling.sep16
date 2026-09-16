using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift2.inkapsling.sep16.klasser
{
     public class BankAccount
    {
        private double balance; //privata informationen

        public void deposit(double amount)
        {
            balance += amount; // tar din balance och lägger till amount
        }

        public void withdraw(double amount)
        {
            balance -= amount; // tar din balance och subtraherar amount
        }

        public double getBalance()
        {
            return balance; // returnerar balance
        }
    }
}
