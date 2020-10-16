using System;

namespace Ch7and8Lecture //METHODS
{ 
    class Program
    {
        static void Main(string[] args)
        {
            ShowWelcomeMessage();

            //demo of scope
            int a = 12;
            Console.WriteLine($"In the Main() method, a has a value of {a}"); // a is 12
            Console.WriteLine();

            MethodWithItsOwnA(); // a is 250 and 500

            Console.WriteLine($"In the Main() method, a has a value of {a}"); // a is still 12 
            Console.WriteLine();

            //method with single input parameter
            double saleAmount = 100.00;
            DisplaySalesTax(saleAmount);
            DisplaySalesTax(200.00); //can also pass with a value instead of variable

            const double RATE = 0.07;
            DisplaySalesTax(saleAmount, RATE); //use same method name with different parameters

            double myHours = 37.5;
            double myRate = 23.75;
            double grossPay;
            Console.WriteLine($"I worked {myHours} hours at {myRate:C} per hour");

            //making a method that returns a value
            grossPay = CalculatePay(myHours, myRate); 
            Console.WriteLine($"My gross pay is {grossPay:C}");
            Console.WriteLine();

            //method that returns a boolean
            Console.WriteLine("Test input(0) = {0}", TestInput(0));;
            Console.WriteLine("Test input(1) = {0}", TestInput(1));
            Console.WriteLine("Test input(15) = {0}", TestInput(15));
            Console.WriteLine();

            //using an array in a method
            int[] someNums = { 10, 12, 22, 35 };
            int x;

            Console.WriteLine("At beginning of Main() method...");
            for (x = 0; x < someNums.Length; ++x) {
                Console.WriteLine("{0, 6}", someNums[x]); }
            Console.WriteLine();

            MethodGetsArray(someNums); //method that takes array as a parameter
            Console.WriteLine();

            Console.WriteLine("At end of Main() method.....");
            for (x = 0; x < someNums.Length; ++x) {
                Console.WriteLine("{0, 6}", someNums[x]); }

            Console.WriteLine();

            // Passing parameters by reference
            int xx = 4;
            Console.WriteLine("Pass by Reference"); 
            Console.WriteLine("In Main x is {0}", xx); //xx=4
            DisplayReferenceParameter(ref xx); //reference is a hexadecimal memory address
            Console.WriteLine("In Main x is {0}", xx); //xx=888
            Console.WriteLine();

            // Returning a reference from a method
            int xxx = 4;
            Console.WriteLine();
            Console.WriteLine("Pass by Value");
            Console.WriteLine("In Main x is {0}", xxx); //xxx=4
            DisplayValueParameter(xxx);
            Console.WriteLine("In Main x is {0}", xxx); //xxx=still 4

            // Overloading methods
            // Overloading involves the ability to write multiple versions of a method using the same method name

            Console.WriteLine(); //WriteLine is an example of an overload
            DisplayWithBorder("Kaitlyn");
            DisplayWithBorder(21); //use same method with a diff data type
            DisplayWithBorder("Go bears"); //depending on data type, that version of the method will be executed
        }

        private static void DisplayWithBorder(int number)  //does same thing as other method just with int
        {
            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = EXTRA_STARS + 1;
            int leftOver = number;
            int x;

            while (leftOver >= 10)
            {
                leftOver = leftOver / 10; ++size;
            }
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);

            Console.WriteLine();
            Console.WriteLine(SYMBOL + " " + number + " " + SYMBOL);

            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);

            Console.WriteLine("\n\n");
        }

        private static void DisplayWithBorder(string word)
        {
            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = word.Length + EXTRA_STARS;
            int x;

            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);

            Console.WriteLine();
            Console.WriteLine(SYMBOL + " " + word + " " + SYMBOL);
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);

            Console.WriteLine("\n\n");
        }

        private static void DisplayValueParameter(int number)
        {
            number = 888; //this number will not be passed back to Main()
            Console.WriteLine($"In method, number is {number}");
        }

        private static void DisplayReferenceParameter(ref int number) //ref = reference
        {
            number = 888; //we have changed the reference value, this number will be retained & passed back to Main()
            Console.WriteLine($"In method, number is {number}");
        }

        private static void MethodGetsArray(int[] vals)
        {
            int x;

            Console.Write("In MethodGetsArray() ");

            for (x = 0; x < vals.Length; ++x)
                Console.Write(" {0}", vals[x]);
            Console.WriteLine();

            for (x = 0; x < vals.Length; ++x)
                vals[x] = 888;
            Console.Write("After change");

            for (x = 0; x < vals.Length; ++x)
                Console.Write(" {0}", vals[x]);
            Console.WriteLine();
        }

        private static bool TestInput(int value) //returning a boolean
        {
            if (value < 1 || value > 10)
                return false;
            else
                return true;
        }

        private static double CalculatePay(double hours, double rate) //returning a double, so "private static double"
        {
            double gross;
            gross = hours * rate;

            return gross; //need return
        }

        private static void DisplaySalesTax(double saleAmount, double rATE)
        {
            double tax;
            tax = saleAmount * rATE; //now have to use RATE as rATE
            Console.WriteLine($"The tax on {saleAmount:C} at {rATE:P1} is {tax:C}"); // :P for percent, P1 does 1 decimal place
            Console.WriteLine();
        }

        private static void DisplaySalesTax(double saleAmount) //this parameter doesn't have to be the one declared earlier
        {
            double tax;
            const double RATE = 0.07;
            tax = saleAmount * RATE;
            Console.WriteLine($"The tax on {saleAmount:C} is {tax:C}"); // :C can replace .ToString("C") !
            Console.WriteLine();
        }

        public static void MethodWithItsOwnA()
        {
            int a = 250;
            Console.WriteLine($"In the method, a has a value of {a}");

            a = a * 2;
            Console.WriteLine($"In the method, a * 2 has a value of {a}");
            Console.WriteLine();
        }

        public static void ShowWelcomeMessage() //void doesn't return a value <3
        {
            Console.WriteLine("Welcome to intro to C#");
            Console.WriteLine("Have fun!");
            Console.WriteLine("Enjoy the code :)");
            Console.WriteLine();
        }
    }
}
