using System;

namespace Hwk7Heishman
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
            SalesTransaction s1 = new SalesTransaction("Kaitlyn", 2000, 0.2); //3 instances of the SalesTransaction class
            SalesTransaction s2 = new SalesTransaction("Kylee", 4000);
            SalesTransaction s3 = new SalesTransaction("Christina");
            SalesTransaction total = s1 + s2 + s3;
            Display(s1);
            Display(s2);
            Display(s3);
            DisplayTotal(total); 

            Console.ReadLine();
        }
        private static void DoExe2()
        {
            Room[] rooms = new Room[8];
            int x, len = 8, wid = 8, hi = 8; //starting point for the smallest room

            for(x=0; x < rooms.Length; x++)
            {
                rooms[x] = new Room(len, wid, hi); //each room increases in size 2 length, 1 width, 1 height every other
                len += 2;
                wid += 1;
                if (x % 2 == 1)
                    hi += 1;
            }

            for(x=0; x < rooms.Length; x++) //list all 8 rooms
            {
                Console.WriteLine($"For a {rooms[x].Length} x {rooms[x].Width} x {rooms[x].Height} foot room");
                Console.WriteLine($"      Two walls are {rooms[x].Length} long and {rooms[x].Height} high");
                Console.WriteLine($"           and the other two walls are {rooms[x].Width} long and {rooms[x].Height} high");
                Console.WriteLine($"      Total wall area is {rooms[x].Area}, so you need {rooms[x].Gallons} gallon(s) of paint.");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        private static void DoExe3()
        {
            Sale[] saleArray = new Sale[10];

            for (int x = 0; x < saleArray.Length; ++x) //cycle through the array to get input 
            {
                saleArray[x] = new Sale(); //sets each input to an instance of the Sale class

                Console.WriteLine($"Enter inventory number #{x+1} >>"); //x+1 starts array at 1 not 0
                saleArray[x].InvNum = Console.ReadLine();
                Console.WriteLine("Enter amount of sale >>");
                saleArray[x].Amount = Convert.ToDouble(Console.ReadLine());           
            }

            for(int x = 0; x < saleArray.Length; ++x) //cycle through the array to display output
            {
                Console.WriteLine($"Sale #{x+1} amount: {x+1} sale {saleArray[x].Amount:C}");
                Console.WriteLine($"      Tax is {saleArray[x].getTax():C}"); 
            }
            Console.ReadLine();
        }     
        private static void DoExe4() 
        {
            Car myCar = new Car(32000, "red");
            Car yourCar = new Car(14000);
            Car theirCar = new Car();  //new Car
            Console.WriteLine("My {0} car cost {1}", myCar.Color, myCar.Price.ToString("c2")); //fixed spelling
            Console.WriteLine("Your {0} car cost {1}", yourCar.Color, yourCar.Price.ToString("c2"));
            Console.WriteLine("Their {0} car cost {1}", theirCar.Color, theirCar.Price.ToString("c2"));
            Console.ReadLine();
        }
        private static void DoExe5() 
        {
            const int STARTING_NUM = 201601; //added underscore
            BoatLicense[] license = new BoatLicense[3]; //made class, made array of 3 since 3 values are given
            int x;

            for (x = 0; x < license.Length; ++x)
            {
                license[x] = new BoatLicense();
                license[x].LicenseNum = ("" + x + STARTING_NUM);
            }

            license[0].State = "WI";
            license[1].State = "MI";
            license[2].State = "MN";
            license[0].MotorSizeInHP = 30;
            license[1].MotorSizeInHP = 50;
            license[2].MotorSizeInHP = 100;
            for (x = 0; x < license.Length; ++x) //capitalized Length
                DisplayBoat(license[x]); //made method

            Console.ReadLine();
        }

        private static void DisplayBoat(BoatLicense boat)
        {
            Console.WriteLine($"Boat #{boat.LicenseNum} from {boat.State} has a {boat.MotorSizeInHP} HP motor.");
            Console.WriteLine($"    The price for the license is {boat.getPrice():C}");
        }

        public static void Display(SalesTransaction s)
        {
            Console.WriteLine($"{s.name} had sales totaling {s.amount:C}. Commission rate is {s.getRate()}; commission value is {s.commission:C}");
        }

        public static void DisplayTotal(SalesTransaction s)
        {
            Console.WriteLine($"Total sales: {s.amount:C}");
        }
    }
}
