using System;

namespace Ch9Lecture
{
    class Program

    {
        static void Main(string[] args)
        {

            //ANIMAL CLASS
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaaw"
            };
            Console.WriteLine(fox.ToString());
            Console.WriteLine();

            Animal dog = new Animal();
            dog.name = "Reese";
            dog.sound = "grrrr";
            Console.WriteLine(dog.ToString());
            Console.WriteLine();

            Animal frog = new Animal(); //if no values are given, the defaults from Animal class will be used
            Console.WriteLine(frog.ToString());
            Console.WriteLine();

            Animal cat = new Animal("Suzanne", "meow"); 
            Console.WriteLine(cat.ToString());
            Console.WriteLine();
            cat.MakeSound();


            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine();

            //BANKACCOUNT CLASS

            //setting up the account
            BankAccount myAccount = new BankAccount(25.00);
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            //making a deposit
            myAccount.Deposit(700.00);
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            //making a withdrawal
            if (myAccount.Withdraw(300.00) < 0)
                Console.WriteLine("Insufficient funds");
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            if (myAccount.Withdraw(450.00) < 0)
                Console.WriteLine("Insufficient funds");
            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            //another account
            BankAccount yourAccount = new BankAccount();
            yourAccount.Deposit(1234.56);

            Console.WriteLine("Your balance = {0:C}", yourAccount.GetBalance());
        }
    }
}
