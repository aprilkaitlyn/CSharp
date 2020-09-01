using System;
namespace Homework1Heishman
{
    class Program
    {

        public enum Planet //enum defined above Main for problem 4
        {
            MERCURY = 1,
            VENUS = 2,
            EARTH = 3,
            MARS = 4,
            SATURN = 5,
            JUPITER = 6,
            URANUS = 7,
            NEPTUNE = 8
        }

        static void Main(string[] args) //homework template
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
        public static string DisplayMenu() //homework template
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

            var result = Console.ReadLine(); //takes user input to run that exercise
            return result;

        }
        private static bool Run(string exeArg) //homework template

        {
            switch (exeArg.ToLower())   
            { 

                case "1":   //executes problem depending on user input
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
            const double CENTIMETER_IN_INCH = 2.54;
            int inches = 8;
            double lengthInCentimeters;

            lengthInCentimeters = CENTIMETER_IN_INCH * inches;
            Console.WriteLine($"{inches} inches is {lengthInCentimeters} centimeters");
            Console.ReadLine();
            
        }
        private static void DoExe2()
        {
            const double CENTIMETER_IN_INCH = 2.54;
            int inches;
            string enterInches;
            double lengthInCentimeters;

            Console.WriteLine("Enter a value in inches >> ");
            enterInches = Console.ReadLine();
            inches = Convert.ToInt32(enterInches);
            lengthInCentimeters = CENTIMETER_IN_INCH * inches;
            Console.WriteLine($"{inches} inches is {lengthInCentimeters} centimeters");
            Console.ReadLine(); //any key returns to menu


        }
        private static void DoExe3()
        {
            string enterDegrees;
            double degrees;
            double convertToCelcius;
            string celcius;
            string fahrenheit;

            Console.WriteLine("Enter Fahrenheit degrees >> ");
            enterDegrees = Console.ReadLine();
            
            degrees = Convert.ToDouble(enterDegrees);
            convertToCelcius = (degrees - 32) * (5.00/9.00);
            
            celcius = convertToCelcius.ToString("F1"); //formatting one decimal place
            fahrenheit = degrees.ToString("F1"); //formatting one decimal place

            Console.WriteLine($"{fahrenheit} F is {celcius} C");
            Console.ReadLine();

        }
        private static void DoExe4()
        {
            string enterNumber;

            Console.WriteLine("Enter a number to see the planet at that position >> ");
            enterNumber = Console.ReadLine();
            Console.WriteLine($"You entered {enterNumber}");

            Planet planet = (Planet)Convert.ToInt32(enterNumber); //reference to Planet enum & converts to int
            Console.WriteLine($"{planet} is {enterNumber} planet(s) from the sun");
            Console.ReadLine();
        }
        private static void DoExe5()
        {  
                string name;
                string firstString, secondString; //fixed spelling of string
                int first, second, product;
                Console.WriteLine("Enter your name >> "); //added "
          
                name = Console.ReadLine(); //added Console to all of these
                Console.WriteLine("Hello, {name}! Enter an integer >> "); 
                firstString = Console.ReadLine();
                first = Convert.ToInt32(firstString);
                Console.WriteLine("Enter another integer >> ");
                secondString = Console.ReadLine();
                second = Convert.ToInt32(secondString); //to Int 32
                product = first * second;
                Console.WriteLine($"Thank you, {name}. The product of {first} and {second} is {product}"); //changed to interpolation
                Console.ReadLine();

        }
    }
}
