using System;

namespace Hwk8Heishman
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
            var job1 = new Job(111, "Grey", "acrylic painting", 40);
            var job2 = new Job(136, "Brown", "charcoal drawing", 20);
            var job3 = new Job(111, "Green", "pencil drawing", 25);

            Console.WriteLine(job1.ToString()); //print out job info from Job class method
            Console.WriteLine(job2.ToString());
            Console.WriteLine(job3.ToString());
            Console.WriteLine(Job.Equals(job1.jobNumber, job1.custName, job2.jobNumber, job2.custName, job3.jobNumber, job3.custName));
            Console.ReadLine();
        }
        private static void DoExe2()
        {
            Job[] jobArray = new Job[5];

            for (int x = 0; x < jobArray.Length; ++x) //cycle through the array to get input 
            {
                jobArray[x] = new Job(); //sets each input to an instance of the Job class

                Console.WriteLine("Enter job number >>"); 
                jobArray[x].jobNumber = Convert.ToInt16(Console.ReadLine());
                if (x >= 1)
                {
                    while (jobArray[x].jobNumber == jobArray[x - 1].jobNumber)
                    {
                        Console.WriteLine($"Sorry, the job number {jobArray[x].jobNumber} is a duplicate");
                        Console.WriteLine("Please Re Enter >>");
                        jobArray[x].jobNumber = Convert.ToInt16(Console.ReadLine());
                    }
                }
                Console.WriteLine("Enter customer name >>");
                jobArray[x].custName = Console.ReadLine();
                Console.WriteLine("Enter job description >>");
                jobArray[x].jobDescription = Console.ReadLine();
                Console.WriteLine("Enter estimated hours for job>>");
                jobArray[x].estHours = Convert.ToInt16(Console.ReadLine());
            }
            for (int x = 0; x < jobArray.Length; ++x) //cycle through the array to display output
            {
                Console.WriteLine(jobArray[x].ToString());
            }
            Console.WriteLine();
            double total = (jobArray[0].estHours + jobArray[1].estHours + jobArray[2].estHours + jobArray[3].estHours + jobArray[4].estHours) * 45;
            Console.WriteLine($"Total for all jobs is {total:C}");

            Console.ReadLine();
        }
        private static void DoExe3()
        {
            RushJob[] rushJobArray = new RushJob[5];

            for (int x = 0; x < rushJobArray.Length; ++x) //cycle through the array to get input 
            {
                rushJobArray[x] = new RushJob(); //sets each input to an instance of the Job class

                Console.WriteLine("Enter job number >>");
                rushJobArray[x].jobNumber = Convert.ToInt16(Console.ReadLine());
                if (x >= 1) {
                    while (rushJobArray[x].jobNumber == rushJobArray[x - 1].jobNumber) //finds duplicate numbers
                    {
                        Console.WriteLine($"Sorry, the job number {rushJobArray[x].jobNumber} is a duplicate");
                        Console.WriteLine("Please Re Enter >>"); 
                        rushJobArray[x].jobNumber = Convert.ToInt16(Console.ReadLine());
                    } //exits loop when new number is entered
                }
                Console.WriteLine("Enter customer name >>");
                rushJobArray[x].custName = Console.ReadLine();
                Console.WriteLine("Enter job description >>");
                rushJobArray[x].jobDescription = Console.ReadLine();
                Console.WriteLine("Enter estimated hours for job>>");
                rushJobArray[x].estHours = Convert.ToInt16(Console.ReadLine());
            }

            for (int x = 0; x < rushJobArray.Length; ++x) //cycle through the array to display output
            {
                Console.WriteLine(rushJobArray[x].ToString());
            }

            Console.WriteLine();
            double total = (rushJobArray[0].estHours + rushJobArray[1].estHours + rushJobArray[2].estHours + rushJobArray[3].estHours + rushJobArray[4].estHours) * 45;
            double rushTotal = total + (150 * rushJobArray.Length);
            Console.WriteLine($"Total for all jobs is {rushTotal:C}");

            Console.ReadLine();
        }
        private static void DoExe4()
        {
            Customer aRegularCustomer = new Customer(); //no regular customer, just customer
            aRegularCustomer.CustNum = 2514; //CustName
            aRegularCustomer.CustBal = 765.00; //CustBal

            FrequentCustomer aFrequentCustomer = new FrequentCustomer();
            aFrequentCustomer.CustNum = 5719;
            aFrequentCustomer.CustBal = 2_500.00;
            aFrequentCustomer.DiscountRate = 0.15;

            Console.WriteLine($"RegularCustomer #{aRegularCustomer.CustNum} owes {aRegularCustomer.CustBal:C}"); //added Console. & cleaned up

            Console.WriteLine($"FrequentCustomer #{aFrequentCustomer.CustNum} would owe {aFrequentCustomer.CustBal:C} without the discount");

            double newBal = (1 - aFrequentCustomer.DiscountRate) * aFrequentCustomer.CustBal;
            Console.WriteLine($"...with a {aFrequentCustomer.DiscountRate:P0} discount, customer owes {newBal:C}");

            Console.ReadLine();
        }
        private static void DoExe5()
        {
            Console.WriteLine("Only 4 problems on this homework! :)");
            Console.ReadLine();
        }
    }
}
