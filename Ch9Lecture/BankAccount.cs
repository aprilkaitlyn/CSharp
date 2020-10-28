using System;

namespace Ch9Lecture
{
    public class BankAccount
    {
        private double balance; //we don't want any other class to access the balance!

        public BankAccount()
        {
            balance = 0;
        }

        public BankAccount(double initialAmount)
        {
            balance = initialAmount;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double Withdraw(double amount)
        {
            if (balance >= amount)
             {
                balance -= amount;
                return balance;
             }
            else
                return -1.0;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
