using System;

namespace Ch5Lecture //Looooooops
{
    class Program
    {
        static void Main(string[] args)
        {

         //WHILE LOOP

            Console.WriteLine("***** WHILE LOOP *****");
            int count = 1;

            while (count <= 10) //this loop prints out only odd numbers
            {
                if (count % 2 == 0) //if remainder (%) of division is 0, the number is even
                {
                    count++; //have to manually increment a while loop

                    continue; //(if it's even) skips the rest of the code & starts back at the top of the while
                }

                // Break jumps completely out of the loop - console won't print 9
                if (count == 9)
                    break;

                Console.WriteLine(count); //print odd numbers
                count++;
            }

            //FOR LOOP

            //  1. Initializing the loop control variable (int i = 0)
            //  2. Testing the loop control variable (i < max)
            //  3. Updating the loop control variable (i++)

            Console.WriteLine();
            Console.WriteLine("***** FOR LOOP *****");

            for(int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine(counter);
            }

            Console.WriteLine();
            const int TIMES = 4;

            for (int x = 0; x < TIMES; x++) //hello bye will be printed 4 times
            {
                Console.WriteLine("Hello");
                Console.WriteLine("Bye");
                Console.WriteLine();
            }

            // DO WHILE LOOP 
            // Use "do while" when you must execute the code at least once

            Console.WriteLine();
            Console.WriteLine("***** DO WHILE LOOP *****");

            // Generate a random number
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11); //11 doesn't count, only goes to 10
            int numberGuessed = 0;

            do
            {
                Console.Write("Enter a number between 1 & 10 : ");

                numberGuessed = Convert.ToInt32(Console.ReadLine()); //put convert & readline together!
            }
            while (secretNumber != numberGuessed); //loop continues when the number guessed isn't the secret number

            Console.WriteLine($"You guessed it! It was {secretNumber}!");

        }
    }
}
