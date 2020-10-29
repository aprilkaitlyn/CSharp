using System;

namespace Hwk7Heishman
{
    public class SalesTransaction
    {

        public string name;
        public double amount;
        readonly double rate; //readonly value
        public double commission;

        public SalesTransaction(string name, double amount, double rate)
        {
            this.rate = rate;
            this.name = name;
            this.amount = amount;

            commission = rate * amount;
        }

        public SalesTransaction(string name, double amount)
        {
            rate = 0; //doesn't need "this"
            this.name = name;
            this.amount = amount;

            commission = rate * amount;
        }

        public SalesTransaction(string name)
        {
            rate = 0; //doesn't need "this"
            amount = 0;
            this.name = name;

            commission = 0;
        }

        public double getRate()
        {
            return rate;
        }

        public static SalesTransaction operator +(SalesTransaction s1, SalesTransaction s2) //overloaded + operator to combine the instances
        {
            double total;
            total = s1.amount + s2.amount; //s3 has no commission and overloaded + can only be 2
            return new SalesTransaction("Total", total); // new instance with name = Total... and amount = s1 + s2
        }
    }
}
