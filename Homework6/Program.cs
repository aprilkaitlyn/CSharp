using System;

namespace Hwk6Heishman
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
            Console.WriteLine("Homework 6");
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
            int miles;
            double km;
            Console.WriteLine("Enter miles >>");
            miles = Convert.ToInt16(Console.ReadLine());
        
            km = ConvertToKm(miles); //reference to method

            Console.WriteLine($"{miles} miles is {km} kilometers");
            Console.ReadLine();
        }
        private static void DoExe2()
        {
            int books, days;
            double fee;

            Console.WriteLine("Enter the number of books that are overdue >>");
            books = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Enter the number of days that the {books} books are overdue >>");
            days = Convert.ToInt16(Console.ReadLine());

            fee = CalculateFee(books, days);

            Console.WriteLine($"The fine for {books} books(s) for {days} days(s) is {fee:C}");
            Console.ReadLine();
        }
        private static void DoExe3()
        {
            CalculateTip(30.00, 0.2); //double, double method
            Console.WriteLine();
            CalculateTip(30.00, 5); //double, int method
            Console.ReadLine();
        }
        private static void DoExe4()
        {
            int firstInt = 21, middleInt = 50, lastInt = 99;

            Console.WriteLine($"The numbers are {firstInt}, {middleInt}, {lastInt}");

            ReverseInts(ref firstInt, ref middleInt, ref lastInt); //passes as reference to pass changes 
            Console.WriteLine($"The numbers are {firstInt}, {middleInt}, {lastInt}");

            Console.ReadLine();
        }
        private static void DoExe5()
        {
            FancyDisplay(33);
            FancyDisplay(44, '@'); //only one ' for char
            FancyDisplay(55.55);
            FancyDisplay(77.77, '*');
            FancyDisplay("hello");
            FancyDisplay("goodbye", '#');
            Console.ReadLine();
        }

        private static void FancyDisplay(int num, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, num); //added Console.s  changed all to {0}s
        }
        private static void FancyDisplay(double num, char decoration = 'X') //Display spelled wrong
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, num.ToString("C")); //added {1}
        }
        private static void FancyDisplay(string word, char decoration = 'X') //added string
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, word);
        }

        private static void ReverseInts(ref int firstInt, ref int middleInt, ref int lastInt)
        {
            firstInt = 99; //changing the int values to pass back to Main()
            lastInt = 21;
        }

        private static void CalculateTip(double meal, int tip)
        {
            double percent, total;
            total = tip + meal;
            percent = tip / meal;
            Console.WriteLine($"Meal price: {meal:C}.  Tip percent: {percent:P0}");
            Console.WriteLine($"Tip in dollars: {tip:C}.  Total bill: {total:C}");
        }
        private static void CalculateTip(double meal, double percent)
        {
            double tip, total;
            tip = percent * meal;
            total = tip + meal;
            
            Console.WriteLine($"Meal price: {meal:C}.  Tip percent: {percent:P0}"); //P0 rounds percent to a whole number
            Console.WriteLine($"Tip in dollars: {tip:C}.  Total bill: {total:C}");
        }

        private static double CalculateFee(int books, int days)
        {
            double fee;

            if (days <= 7)
                fee = books * days * 0.1; //calculates 1 - 7 days
            else
                fee = (books * (days-7) * 0.2) + (0.7); //adds additional days to the $0.70 week late fee

            return fee;
        }

        private static double ConvertToKm(int miles)
        {
            const double CONVERT = 1.60934;
            double km;
            km = CONVERT * miles;

            return km;
        }
    }
}
