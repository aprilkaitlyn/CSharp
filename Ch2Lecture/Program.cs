using System;
using System.Reflection;
using System.Numerics;

namespace ch2lectures //using data, variables, and data types

{
    class Program
    {

        static void Main(string[] args)
        {
         //declaring variables

            int Age;
            int myAge = 21;
            int yourAge = 22;
            int myYear = 1999, yourYear = 1998; //can define multiple variables together under same type

            bool willPass = true; //boolean is bool in C#
            string name = "Kaitlyn";

         //displaying variables

            double someMoney = 101.24;
            Console.WriteLine(someMoney); //Console.WriteLine() shortcut -- type cw & press tab twice

            double moreMoney = 929.61;
            Console.Write("The money is $"); 
            Console.WriteLine(moreMoney); //these combine together on one line

            Console.WriteLine("The money is $" + moreMoney); //same result as writing Write & WriteLine separately

         //placeholder method
            string mySentence = String.Format("The money is ${0} exactly", moreMoney); //curly braces indicate placeholder
            Console.WriteLine(mySentence);
            Console.WriteLine("The money is ${0} and my age is {1}", someMoney, myAge); //can do with multiple variables in one line
            Console.WriteLine(); //blank WriteLine will make an empty line in console

         //string interpolation (newer feature)
            string yourSentence = $"The money is ${moreMoney} exactly"; //$ indicates "interpolation", same result as placeholder
            Console.WriteLine(yourSentence);
            Console.WriteLine();
            Console.WriteLine($"The money is ${someMoney} and my age is {myAge}");

            Console.WriteLine($"The money is {moreMoney.ToString("c")} exactly"); //using ToString is an older method, "c" format = currency
            Console.WriteLine($"The money is {moreMoney:c} exactly"); //using :c formats as currency the same as above line

            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine();

         //integral data types - stores whole numbers. Only use what you need to save memory!

            //INTEGERS - 32 bit signed
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue); //the biggest integer you can use
            Console.WriteLine("Smallest Integer: {0}", int.MinValue); //the smallest integer you can use
            Console.WriteLine();

            //LONGS - 64 bit signed
            Console.WriteLine("Biggest Long : {0}", long.MaxValue); //the biggest long integer you can use
            Console.WriteLine("Smallest Long : {0}", long.MinValue); //the smallest long integer you can use
            Console.WriteLine();

            //BIGINTEGER - very large numbers
            BigInteger bigNum = BigInteger.Parse("12345678909876543210");
            Console.WriteLine("Big num * 2 = {0}", bigNum * 2);
            Console.WriteLine();

            //SHORT - 16 bit signed
            //UINT - 32 bit unsigned
            //USHORT - 16 bit unsigned
            //ULONG - 64 bit unsigned 

         //floating point data type
            // FLOAT - 32-bit float types
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

            // It is precise to 7 digits
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);
            Console.WriteLine();

            // DOUBLES - 64-bit float types
            // A double data type can hold 15 or 16 significant digits of accuracy.
            // A double given the value 123456789.987654321 will appear as 123456789.987654
            double dblNumber = 123456789.987654321D;
            Console.WriteLine($"The double 123456789.987654321 will appear as {dblNumber}");
            Console.WriteLine();

            // DECIMALS - 28-bit precise decimal values & it is accurate to 28 digits
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
            Console.WriteLine();

            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;
            Console.WriteLine("float: {0} double: {1} decimal: {2}", flt, dbl, dcm);

            // Formatting Floating Point Numbers
            double myMoney = 14.00;
            Console.WriteLine("14.00 prints as {0}", myMoney);
            Console.WriteLine(
                "The two zeros to the right of the decimal point in the assigned value will not appear in the output because they add no mathematical information. ");
            Console.WriteLine();

            double someMoney2 = 123;
            string moneyString;
            moneyString = someMoney2.ToString("F2");
            Console.WriteLine($"The double 123 prints like this using the F2 string formatter {moneyString}");
            moneyString = someMoney2.ToString("F3");
            Console.WriteLine($"The double 123 prints like this using the F3 string formatter {moneyString}");
            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            //using arithmetic operators
            int i = 1;
            int j = 2;

            int result = i + j;
            Console.WriteLine($"i + j = {result}");
            Console.WriteLine();

            int result2 = i - j;
            Console.WriteLine($"i - j = {result2}");
            Console.WriteLine();

            int result3 = i * j;
            Console.WriteLine($"i * j = {result3}");
            Console.WriteLine();

            int result4 = i / j;
            Console.WriteLine($"i / j = {result4}");
            Console.WriteLine();

            i = i + 5;
            Console.WriteLine($"i + 5 = {i}"); // i is now 6      i = i + 5 and i += 5 both make i now 6
            Console.WriteLine();

            i += 5;
            Console.WriteLine($"i += 5 = {i}"); // 6 + 5 = 11, i is now 11
            Console.WriteLine();

            i++;
            Console.WriteLine($"i++ = {i}"); // 11++ is 12
            Console.WriteLine();

            i--;
            Console.WriteLine($"i--= {i}"); // 12-- is 11
            Console.WriteLine();

            int k = 127;
            int h = 8;
            var mod = k % h; //var keyword doesn't specify data type 
            Console.WriteLine($"k % h = {mod}"); // modulus - remainder of 127/8 is 7
            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine();


         //boolean data type * bool *
            bool canIlegallyDrink = true;
            Console.WriteLine(canIlegallyDrink);

            bool b = false;
            Console.WriteLine(b); // WriteLine automatically converts the value of b to text.
            Console.WriteLine();

            bool isBigger = 6 > 5; // Value stored would be true
            Console.WriteLine(isBigger);

            bool isSmallerOrEqual = 7 <= 4; // Value stored would be false
            Console.WriteLine(isSmallerOrEqual);
            Console.WriteLine();

            int hoursWorked = 50;
            int annualIncome = 90000;

            bool doesEmployeeReceiveOvertime = hoursWorked > 40;
            Console.WriteLine(doesEmployeeReceiveOvertime);

            bool isHighTaxBracket = annualIncome > 100000;
            Console.WriteLine(isHighTaxBracket);
            Console.WriteLine();


         //CHARRR - only one character
            char initial = 'K';
            Console.WriteLine(initial);
            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine();

         //NON PRINTING VALUES - use a back slash
            //backspace ? = \b
            //alert sound ? = \a
            //tab - \t
            //split onto the next line - \n

            Console.WriteLine("This line\tcontains two\ttabs");
            Console.WriteLine("This statement\ncontains a new line");
            Console.WriteLine("This statement sounds an alert \a"); //doesn't work for me ??
            Console.WriteLine();


            const int INCHES_IN_A_FOOT = 12;
            int LengthInFeet = 2;
            int LengthInInches;
            LengthInInches = LengthInFeet * INCHES_IN_A_FOOT;
            Console.WriteLine(LengthInInches);
        }

    }
}
