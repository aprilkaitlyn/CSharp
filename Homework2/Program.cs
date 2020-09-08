using System;

namespace Homework2Heishman
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
            string s1 = "Missouri State University College of Business";
            int start = s1.IndexOf(" ") + 1;
            Console.WriteLine(start);
            string secondWord = s1.Substring(start, s1.IndexOf(" ", start) - start);
            Console.WriteLine($"Second word: {secondWord}");
            Console.ReadLine(); //press any key to go back to the menu
        }
        private static void DoExe2()
        {
            string name = "Kaitlyn";
            var date = DateTime.Now;

            //COMPOSITE
            Console.WriteLine("Hello {0}! Today is {1}, it's {2:g} now.", name, date.DayOfWeek, date); //g format from Microsoft website
            Console.WriteLine();

            //INTERPOLATION
            Console.WriteLine($"Hello {name}! Today is {date.DayOfWeek}, it's {date:g} now."); 
            Console.WriteLine();
            Console.ReadLine();
        }
        private static void DoExe3()
        {
            string s2 = "The path is C:\\Windows\\System32"; //use a double backslash in code, will write as just one
            Console.WriteLine(s2);

            string s3 = @"The path is C:\Windows\System32"; //or add @ to the beginning
            Console.WriteLine(s3);
            Console.ReadLine();
        }
        private static void DoExe4()
        {
            const double WITHHOLDING_RATE = 15;
            string hoursAsString, rateAsString;
            double hours, rate;
            double gross, withholding, net;

            Console.WriteLine("Enter the number of hours you worked this week >> "); //added missing Consoles throughout
            hoursAsString = Console.ReadLine(); //fixed capitalization

            Console.WriteLine("Enter your hourly rate >> ");
            rateAsString = Console.ReadLine(); //added ;
            Console.WriteLine(); //added for readability

            hours = Convert.ToDouble(hoursAsString); //fixed spelling
            rate = Convert.ToDouble(rateAsString); //fixed spelling
            gross = hours + rate;
            withholding = gross * WITHHOLDING_RATE;
            net = gross * withholding;

            Console.WriteLine("You worked {0} hours at {1} per hour", hours, rate.ToString("C"));
            Console.WriteLine("Gross pay is {0}", gross.ToString("C"));
            Console.WriteLine("Withholding is {0}", withholding.ToString("C"));
            Console.WriteLine("Net pay is {0}", net.ToString("C")); //added .
            Console.ReadLine();
        }
        private static void DoExe5()
        {
            string name, bossName; //added ;
            bool areNamesTheSame;

            Console.WriteLine("Enter your name >> "); //added consoles
            name = Console.ReadLine();

            Console.WriteLine("Hello {0}! Enter the name of your boss >> ", name);
            bossName = Console.ReadLine();

            areNamesTheSame = String.Equals(name, bossName);
            Console.WriteLine("It is {0} that you are your own boss", areNamesTheSame); //fixed variable name
            Console.ReadLine();
        }
    }
}
