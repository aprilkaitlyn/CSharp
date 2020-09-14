using System;

namespace Ch4Lecture
{
    class Program
    {
        public enum Color { Red, Green, Blue } //for switch case

        static void Main(string[] args)
        {
            // == for comparison, = for assignment

            //LOGICAL OPERATORS: && (and) || (or) ! (not)
           
            int myAge = 21;

            if (myAge == 21) //an if w/ only one statement doesn't need { }
            {
                Console.WriteLine($"Age = {myAge}");
            }

            string inputAge;
            int age;
            Console.WriteLine();
            Console.WriteLine("Enter your age >> ");
            inputAge = Console.ReadLine();
            age = Convert.ToInt32(inputAge);

            //AND IF STATEMENT &&
            if (age >= 5 && age <= 10)
                Console.WriteLine("Go to elementary school");
            else if (age > 10 && age < 13)
                Console.WriteLine("Go to middle school");
            else if (age > 13 && age < 18)
                Console.WriteLine("Go to high school");
            else if (age > 18 && age < 22)
                Console.WriteLine("Go to college");
            else if (age == 22)
                Console.WriteLine("Go to graduate school");
            else
                Console.WriteLine("Go to work!");

            //OR IF STATEMENT ||
            if (age < 16 || age > 67)
                Console.WriteLine("You shouldn't work");

            Console.WriteLine();

            //TERNARY OPERATOR ?
            bool canDrive = age >= 16 ? true : false;
            Console.WriteLine();
            Console.WriteLine($"Can drive? {canDrive}");
            Console.WriteLine();

            //SWITCH CASE
            Color color = (Color)new Random().Next(0, 3); //color from enum
            Console.WriteLine("Switch Statement");
            switch (color)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown!");
                    break;
            }
            Console.WriteLine();

            //MATCH EXPRESSION
            Random rnd = new Random();
            int caseSwitch = rnd.Next(1, 4);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2: //nothing here makes it do the same thing as case 3
                case 3:
                    Console.WriteLine($"Case {caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"An unexpected value ({caseSwitch})");
                    break;
            }
            Console.WriteLine();

            //NOT OPERATOR !
            int pAge;
            pAge = 20;
            int premium;

            if (pAge < 26)
                premium = 200;
            else
                premium = 125;
            Console.WriteLine($" Premium = {premium}");

            if (!(pAge < 26))
                premium = 125;
            else
                premium = 200;
            Console.WriteLine($" Premium = {premium}");

            if (pAge >= 26)
                premium = 125;
            else
                premium = 200;
            Console.WriteLine($" Premium = {premium}");

            if (!(pAge >= 26))
                premium = 200;
            else
                premium = 125;
            Console.WriteLine($" Premium = {premium}"); //all 4 return the same result !
            Console.WriteLine();

        }
    }
}
