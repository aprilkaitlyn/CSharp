using System;

namespace StringsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //IT'S TIME FOR STRINGS
            string string1 = "This is a string created by assignment";
            Console.WriteLine(string1);
            Console.WriteLine();

            string string2 = "The path is c:\\temp\\log.txt"; //use a double backslash in code, will write as just one
            Console.WriteLine(string2);
            Console.WriteLine();

            string string3 = @"The path is c:\temp\log.txt"; //or add @ to the beginning
            Console.WriteLine(string3);
            Console.WriteLine();

            char[] chars = { 'w', 'o', 'r', 'd'};
            string string4 = new string(chars); //casting those above characters as a string
            Console.WriteLine(string4); //prints "word" to the console
            Console.WriteLine();

            string string5 = new string('*', 25); //will print 25 *s
            Console.WriteLine(string5);
            Console.WriteLine();

            //COMBINING STRINGS

            string string6 = "Today is " + DateTime.Now.ToString("D"); //cast the date into a string, "D" is the format of Monday, September 7, 2020
            Console.WriteLine(string6);
            Console.WriteLine();

            string string7 = "This is a sentence." + " So is this.";
            string7 += " This is another sentence";
            Console.WriteLine(string7);
            Console.WriteLine();

            //INDEXOF

            string sentence = "This sentence is five words";
            int startPosition = sentence.IndexOf(" ") + 1;
            Console.WriteLine(startPosition);
            string word2 = sentence.Substring(startPosition, sentence.IndexOf(" ", startPosition) - startPosition); //finds the second word in the sentence?
            Console.WriteLine(word2);
            Console.WriteLine();

            //FORMATING DATES AND TIMES

            DateTime dateAndTime = new DateTime(2020, 9, 8, 16, 9, 0); //writing all the numbers out yourself
            double temperature = 88.5; //this is the temp rn no lie
            string result = String.Format("At {0:t} on {0:D} the temperature was {1:F1} degrees", dateAndTime, temperature); // t = short time D = long date F = ??
            Console.WriteLine(result);
            Console.WriteLine();

            //COMPOSITE/PLACEHOLDER FORMATTING

            string name = "Kaitlyn";
            var date = DateTime.Now;

            Console.WriteLine("Hello {0}! Today is {1}, it's {2:HH:mm} now", name, date.DayOfWeek, date);
            Console.WriteLine();

            //INTERPOLATION <3

            Console.WriteLine($"Hello {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now"); //HH:mm is a time format
            Console.WriteLine();

            //STRINGS & INDEXES

            string s1 = "This string is a single sentence.";
            int numWords = 0; //important: it starts at 0!

            s1 = s1.Trim(); //Trim cleans up the string (of extra spaces?)

            for (int ctr = 0;  ctr < s1.Length;  ctr++) //can do for - tab tab
            {
                if (Char.IsPunctuation(s1[ctr])||Char.IsWhiteSpace(s1[ctr])) //goes through each character to determine if its punctuation or white space
                {
                    numWords++; //determines it found a word when punctuation or white space appears
                }
            }
            Console.WriteLine($"The sentence: \n {s1}\n has {numWords} words"); // \n puts it on a new line!
            Console.WriteLine();


            //COMPARING STRINGS

            string stringA = "a houseboat";
            string stringB = stringA.Substring(2, 5); //start at 2nd char (h) & pull out 5 letters (house)
            string stringC = "House";

            Console.WriteLine("stringA == stringB is {0}", stringA == stringB); //boolean
            Console.WriteLine("stringA.Equals(stringB) is {0}", stringA.Equals(stringB)); //.Equals and == are the same
            Console.WriteLine($"stringA.Equals(stringB) is {stringA.Equals(stringB)}"); //using interpolation
            Console.WriteLine();

            //COMPARING WITH CASE SENSITIVITY

            Console.WriteLine("stringB.Equals(stringC) is {0}", stringB.Equals(stringC)); //house vs House case sensitive

            string stringE = "Apple";
            string stringF = "apple";

            Console.WriteLine("{0} compared to {1} is {2}", stringE, stringF, stringE.CompareTo(stringF)); //returns 1 meaning they are not the same
            Console.WriteLine("{0} compared to {1} is {2}", stringE, stringF, String.Compare(stringE, stringF, false)); //same as above, returns 1
            Console.WriteLine("{0} compared to {1} is {2}", stringE, stringF, String.Compare(stringE, stringF, true)); //ignores case differences, returns 0

        }
    }
}
