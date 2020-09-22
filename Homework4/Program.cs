using System;

namespace Homework4Heishman
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");
        }
        public static string DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Homework 1");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;
        }
        private static bool Run(string exeArg)
        {
            switch (exeArg.ToLower())
            {
                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }
        private static void DoExe1()
        {
            char letter;

            Console.WriteLine("Enter an uppercase letter >>");
            letter = Convert.ToChar(Console.ReadLine()); //convert input to char

            while (letter != '!') //! will end the program
            {           
                if (Char.IsUpper(letter) == true)
                 {
                    Console.WriteLine("OK");
                    Console.WriteLine();
                    Console.WriteLine("Enter an uppercase letter or ! to quit");
                    letter = Convert.ToChar(Console.ReadLine());
                 }

                else //includes lowercase & other chars
                 {
                    Console.WriteLine("Sorry - that was not an uppercase letter.");
                    Console.WriteLine();
                    Console.WriteLine("Enter an uppercase letter or ! to quit");
                    letter = Convert.ToChar(Console.ReadLine());
                 }                           
            }
        }
        private static void DoExe2()
        {
            string phrase;
            int vowels = 0; 

            Console.WriteLine("Enter a phrase >> ");
            phrase = Console.ReadLine().ToLower(); //to simplify for loop!

            for (int v = 0; v < phrase.Length; v++) //max is length of phrase
            {
                if (phrase[v] == 'a' || phrase[v] == 'e' || phrase[v] == 'i' || phrase[v] == 'o' || phrase[v] == 'u')
                {
                    vowels++;
                }
            }

            Console.WriteLine($"There are {vowels} vowels in {phrase}");

            Console.ReadLine();
        }
        private static void DoExe3()
        {
            int halfSum, fullSum;
            int sum1 = 0, sum2 = 0;

            for (halfSum = 1; halfSum < 100; halfSum++) //first half
            {
                sum1 = sum1 + halfSum;
            }
            Console.WriteLine("Halfway through....");
            Console.WriteLine($" after 100 numbers, sum is {sum1}");

            for (fullSum = 1; fullSum <= 200; fullSum++) //second half
            {
                sum2 = sum2 + fullSum;
            }
            Console.WriteLine($"The sum of the integers 1 through 200 is {sum2}");
            Console.WriteLine();

            Console.ReadLine();
        }   
        private static void DoExe4()
        {
            const string ITEM209 = "209", ITEM312 = "312", ITEM414 = "414";
            const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
            double price;
            string stockNum;

            Console.Write("Please enter the stock number of the item you want > ");
            stockNum = Console.ReadLine(); //added COnsole

            while (stockNum != ITEM209 && stockNum != ITEM312 && stockNum != ITEM414) // changed || to &&
            {
                Console.WriteLine("Invalid stock number. Please enter again. ");
                stockNum = Console.ReadLine();
            }

            if (stockNum == ITEM209)
                price = PRICE209;
            else if (stockNum == ITEM312)
                price = PRICE312;
            else
                price = PRICE414; //switched 312 and 414

            Console.WriteLine("The price for item #{0} is {1}", stockNum, price.ToString("C"));

            Console.ReadLine();
        }
        private static void DoExe5()
        {
            const double LIMIT = 1000000.00;
            const double START = 0.01;
            string inputString;
            double total;
            int howMany;
            int count;

            Console.WriteLine("How many days do you think it will take you to reach"); //combined
            Console.WriteLine("{0} starting with {1}", LIMIT.ToString("C"), START.ToString("C") + " and doubling it every day?"); //added "C" and )
            inputString = Console.ReadLine(); //added Console
            howMany = Convert.ToInt32(inputString);
            count = 0; 
            total = START;
            while (total < LIMIT) //changed to <
            {
                total = total * 2;
                count = count + 1;
                continue; //added to continue looping
            }
           
            if (howMany > count) //changed to >
                Console.WriteLine("Your guess was too high.");
            else if (howMany < count) //changed to <
                Console.WriteLine("Your guess was too low.");
            else
                Console.WriteLine("Your guess was correct.");

            Console.WriteLine("It takes {0} days to reach {1}", count, LIMIT.ToString("C")); //added Console and {}
            Console.WriteLine("when you double {0} every day",
            START.ToString("C"));

            Console.ReadLine();
        }
    }
}
