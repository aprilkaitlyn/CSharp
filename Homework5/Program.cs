using System;
using System.Collections.Generic;

namespace Hwk5Heishman
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
            double total = 0.0;
            double avg, diff;

            //make array for test scores
            double[] scoreArray = new double[8];

            //user input for 8 scores
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Please enter score for test number " + (i + 1) + " >> ");
                scoreArray[i] = Convert.ToDouble(Console.ReadLine());
                total = total + scoreArray[i];
            }

            Console.WriteLine();
            Console.WriteLine("Scores for the tests are:");
            Console.WriteLine();

            //calculate average 
            avg = (total / 8);

            //console output for 8 tests
            for (int i = 0; i < scoreArray.Length; i++)
            {
                diff = (avg - scoreArray[i]);
                Console.WriteLine($"Test # {i}:   {scoreArray[i]} " + $"From average: {diff}");
            }

            //display average & total             
            Console.WriteLine();
            Console.WriteLine("  Total is {0}", total);
            Console.WriteLine("Average is {0}", avg);

            Console.ReadLine();
        }
        private static void DoExe2()
        {
            int warmer = 0;
            int colder = 0;
            double sum = 0;
            double avg;

            //make array for temperatures
            int[] temps = new int[5];

            for (int i = 0; i < 5; i++) //accept only 5 inputs
            {
                Console.Write("Enter temperature " + (i + 1) + " >> ");
                temps[i] = Convert.ToInt32(Console.ReadLine()); //convert input to int

                if (temps[i] < -30 || temps[i] > 130) //out of range
                {
                    Console.WriteLine("Out of range! Re-enter temperature " + (i + 1) + " >> ");
                    temps[i] = Convert.ToInt32(Console.ReadLine());
                }
                sum = sum + temps[i];

                if (i > 1) //doesn't start until temp 2
                {
                    if (temps[i - 1] < temps[i]) //if temp 2 is smaller than temp 3, add to ascending temperatures
                        warmer++;
                    else
                        colder++; //descending temperatures
                }
            }
            Console.WriteLine();

            //determine warm, cold, or mixed
            if (warmer == 3) //from warmer++
            {
                Console.Write("Getting warmer:  ");
              
                
            }
            else if (colder == 3) //from colder++
            {
                Console.Write("Getting cooler:  ");
            
            }
            else
            {
                Console.Write("It's a mixed bag:  ");
                
            }

            //list numbers in order
            for (int i = 0; i < 5; i++) 
            {
                Console.Write(temps[i] + "  ");
            }
            Console.WriteLine();

            //print average
            avg = (sum / 5);
            Console.WriteLine("Average Temperature: " + avg);

            Console.ReadLine();         
        }
        private static void DoExe3()
        {
            int nights;
            double perNight;
            double total;

            Console.WriteLine("How many nights is your stay?" );
            nights = Convert.ToInt16(Console.ReadLine());

            if (nights >= 8) { perNight = 145; }
            else if (nights >= 5) { perNight = 160; }
            else if (nights >= 3) { perNight = 180; }
            else { perNight = 200; }

            Console.WriteLine($"Price per night is {perNight:C}"); //:C for currency

            total = perNight * nights;
            Console.WriteLine($"Total for {nights} night(s) is {total:C}");

            Console.ReadLine();
        }
        private static void DoExe4()
        {
            double[] numbers = { 12, 15, 22, 88 }; //double so average will work
            int x;
            double average;
            double total = 0;

            Console.Write("The numbers are...    ");

            for (x = 0; x < numbers.Length; x++) //x=0 ... combined the for loops
            {
                Console.Write(numbers[x] + "   "); //fix spelling & changed output
                total = total + numbers[x]; //added total +
            }
           
            average = total / numbers.Length; //capital Length
            Console.WriteLine("\nThe average is {0}", average); //added

            Console.ReadLine();
        }
        private static void DoExe5()
        {
            const int QUIT = 999;      
            int x = 0;
            int num;
            double average;
            double total = 0;
            string inString;

            var numbers1 = new List<int>(); //changed array to list since we don't have a definite # 
            
            while (x <= numbers1.Count) //use count with lists, not length
            {
                Console.Write("Please enter a number or " + QUIT + " to quit...");
                inString = Console.ReadLine();
                num = Convert.ToInt32(inString);

                numbers1.Add(num);

                if (num == 999) //break out at 999
                    break;
                numbers1[x] = num;

                total = total + numbers1[x]; 
                x++;
            }

            Console.WriteLine("The numbers are:");

            for (int y = 0; y < x; y++) //y++
                Console.Write(numbers1[y] + " ");

            average = total / x; //z to x
            Console.WriteLine();
            Console.WriteLine("The average is {0}", average); //spelled wrong

            Console.ReadLine();
        }
    }
}
