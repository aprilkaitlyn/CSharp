using System;

namespace Homework3Heishman
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
            string message;
            int count;

            Console.WriteLine("Enter your short message >>");
            message = Console.ReadLine();
            count = message.Length;

            if (count <= 140) {
                Console.WriteLine("The message is okay");
            }
            else
            {
                Console.WriteLine("The message is NOT okay");
            }

            Console.ReadLine();
        }

        private static void DoExe2()
        {
            string inputGPA;
            string inputTestScore;
            double GPA;
            int testScore;

            Console.WriteLine("Enter your GPA >>");
            inputGPA = Console.ReadLine();
            Console.WriteLine("Enter your test score >>");
            inputTestScore = Console.ReadLine();
            Console.WriteLine();

            GPA = Convert.ToDouble(inputGPA);
            testScore = Convert.ToInt16(inputTestScore);   //conversions for if statement comparisons

            if (GPA >= 3.0 && testScore >= 60){
                Console.WriteLine("Accept");
            }
            else if (GPA < 3.0 && testScore >= 80) {
                Console.WriteLine("Accept");
            }
            else {Console.WriteLine("Reject");}

            Console.ReadLine();
        }

        private static void DoExe3()
        {
            string input;
            int rps;
            char user;
            char computer = ' ';
            Random random = new Random();

            Console.WriteLine("Enter r, p, or s for rock, paper, or scissors >>");
            input = Console.ReadLine();
            user = Convert.ToChar(input);
            rps = random.Next(3);

            switch (rps)
            {
                case 1:
                    computer = 'r';
                    Console.WriteLine("Computer picked rock");                  
                    break;
                case 2:
                    computer = 'p';
                    Console.WriteLine("Computer picked paper");                    
                    break;
                case 3:
                    computer = 's';
                    Console.WriteLine("Computer picked scissors");                   
                    break;
            }

            if (user == computer)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (((user == 'r') && (computer == 's')) ||
                     ((user == 's') && (computer == 'p')) ||
                     ((user == 'p') && (computer == 'r')))
            {
                Console.WriteLine("You win");
            }
            else if
                (((user == 's') && (computer == 'r')) ||
                 ((user == 'p') && (computer == 's')) ||
                 ((user == 'r') && (computer == 'p')))
            {
                Console.WriteLine("You lose");
            }

            Console.ReadLine();
        }
        
        private static void DoExe4()
        {
            // Program decides tuition based on several criteria:
            // 1 - 12 credit hours @ $150 per credit hour
            // 13 - 18 credit hours, flat fee $1900
            // over 18 hours, $1900 plus $100 per credit hour over 18
            // If year in school is 4, there is a 15% discount

            int credits, year; //comma
            string inputString;
            double tuition;
            const int LOWCREDITS = 12;
            const int HIGHCREDITS = 18;
            const double HOURFEE = 150.00; //15000 --> 150.00
            const double DISCOUNT = 0.15;
            const double FLAT = 1900.00;
            const double RATE = 100.00;
            const int SENIORYEAR = 4;

            Console.WriteLine("How many credits? ");
            inputString = Console.ReadLine();
            credits = Convert.ToInt32(inputString);

            Console.WriteLine("Year in school? ");
            inputString = Console.ReadLine(); //capital L
            year = Convert.ToInt32(inputString);

            if (credits <= LOWCREDITS) // 12 or less hours is $150 * credits
                tuition = HOURFEE * credits;

            else if (credits <= HIGHCREDITS && credits >= 13) //13 to 18 hours is flat fee $1900
                tuition = FLAT;

            else
                tuition = FLAT + ((credits - HIGHCREDITS) * RATE); //over 18 is flat fee $1900 + $100 * extra credits

            if (year == SENIORYEAR) //has to be year 4
                tuition = tuition - (tuition * DISCOUNT);

            Console.WriteLine("For year {0}, with {1} credits", year, credits);
            Console.WriteLine("Tuition is {0}", tuition.ToString("C"));

            Console.ReadLine();
        }

        private static void DoExe5()
        {
            // Program takes a hot dog order
            // And determines price

            const double BASIC_DOG_PRICE = 2.00;
            const double CHILI_PRICE = 0.69;
            const double CHEESE_PRICE = 0.49;
            string wantChili, wantCheese; 
            double price;

            Console.WriteLine("Do you want chili on your dog? ");      //Added Consoles throughout
            wantChili = Console.ReadLine(); //mispelled chilli
            Console.WriteLine("Do you want cheese on your dog? ");
            wantCheese = Console.ReadLine();

            if (wantChili == "Y")  // fixed = and ==
            {
                if (wantCheese == "Y")
                    price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
                else
                    price = BASIC_DOG_PRICE + CHILI_PRICE;
            }

            else if (wantCheese == "Y") {
                price = BASIC_DOG_PRICE + CHEESE_PRICE;
            } 

            else { price = BASIC_DOG_PRICE; }

            Console.WriteLine("Your total is {0}", price.ToString("C"));
            Console.ReadLine();
        }
    }
}
