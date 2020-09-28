using System;
using System.Collections.Generic; //used for Lists

namespace Ch6Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
          // ----- ARRAYS -----
          // Arrays are boxes inside of a bigger box that
          // can contain many values of the same data type
          // Each item is assigned a key starting at 0
          // and incrementing up from there
          // Arrays have fixed sizes

            int[] favNums = new int[3]; //declares array is made of 3 integers

            //add value to the array
            favNums[0] = 21; //first element of the array is 0
            Console.WriteLine($"Favorite number is: {favNums[0]}");
            Console.WriteLine();

            //create & fill array at the same time
            string[] customers = {"Christina", "Kylee", "Roland"};

            //arrays can be made with "var" as long as data types are all the same
            var dogs = new[] {"Reese", "Mickey", "Ruby"};

            //arrays can be made with "object" to use different data types
            object[] randomArray = {"Kaitlyn", 21, 4.29};


            //see Vehicle.cs class 
            Vehicle[] vehicleArray = new Vehicle[100];

            vehicleArray[0] = new Vehicle();
            vehicleArray[0].Speed = 125.5;
            vehicleArray[0].Wheels = 4;

            // GetType knows its data type
            Console.WriteLine("randomArray element 0 is: {0}", randomArray[0].GetType());
            Console.WriteLine("randomArray element 1 is: {0}", randomArray[1].GetType());
            Console.WriteLine("vehicle wheels at element 0 is: {0}", vehicleArray[0].Wheels.GetType());
            Console.WriteLine();

            // Get number of items in array
            Console.WriteLine("Array Size : {0}", randomArray.Length);
            Console.WriteLine();

            // Use a for loop to cycle through the array
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array element {0} is: {1}", i, randomArray[i]);
            }
            Console.WriteLine();

            //or use foreach to cycle through the array -- "item" can be any word you want
            foreach (var item in randomArray)
            {
                Console.WriteLine("Array element is: {0}", item);
            }
            Console.WriteLine();

            // ----- LISTS -----
            // Do not have to be initialized with a length
            // Represents a strongly typed list of objects that can be accessed by index
            // Provides methods to search, sort, and manipulate lists

            //list method 1: declare a list & add to it using .Add
            var numbers1 = new List<int>();
            numbers1.Add(2);
            numbers1.Add(3);
            numbers1.Add(5);
            numbers1.Add(7);
            Console.WriteLine("LIST 1: " + numbers1.Count);

            //list method 2: declare a list & add to it in curly braces
            var numbers2 = new List<int>() {2, 3, 5, 7};
            Console.WriteLine("LIST 2: " + numbers2.Count);
            Console.WriteLine();

            //loop through the list with foreach
            foreach (int number in numbers2)
            {
                Console.WriteLine("Element # {0}", number);
            }
            Console.WriteLine();

            //making a list from the Vehicle.cs class
            List<Vehicle> listOfVechVehicles = new List<Vehicle>(); //declare without adding to list
            List<Vehicle> listOfVechVehicles2 = new List<Vehicle> //declare adding 3 items to list
            {

                new Vehicle() {Brand = "Ford", Speed = 50, Wheels = 4},
                new Vehicle() {Brand = "Mini", Speed = 50, Wheels = 4},
                new Vehicle() {Brand = "Nissan", Speed = 50, Wheels = 4},

            };

            foreach (var vehicle in listOfVechVehicles2)
            {
                Console.WriteLine(vehicle.Brand);
                Console.WriteLine(vehicle.Wheels);
                Console.WriteLine();
            }

            Console.WriteLine("Number of vehicles = {0}", listOfVechVehicles2.Count.ToString());
            Console.WriteLine();


            // ----- VARIOUS FUNCTIONS -----

            int[] randNums = { 1, 4, 9, 2 };

            // Pass array to function 
            PrintArray(randNums, "ForEach"); //see PrintArray at the bottom! lists the array in order coded
            Console.WriteLine();

            // Sort
            Array.Sort(randNums); //low to high 1, 2, 4, 9
            PrintArray(randNums, "Sorted"); 
            Console.WriteLine();

            // Reverse Sort
            Array.Reverse(randNums); //high to low 9, 4, 2, 1
            PrintArray(randNums, "Reverse Sorted");
            Console.WriteLine();

            // Get the index to search for a value
            Console.WriteLine("1 is found at index {0}", Array.IndexOf(randNums, 1)); //pass the array & thing to search for
            Console.WriteLine("4 is found at index {0}", Array.IndexOf(randNums, 4)); //remember index starts at 0 for position 1
            Console.WriteLine();

            // Change value at a specific index
            randNums.SetValue(0, 3); //changing index 0 to a value of 3
            PrintArray(randNums, "Changed the value at index 0 to a 3");
            Console.WriteLine();

            // Copy part of an array to another
            int[] sourceArray = { 1, 2, 3 }; //source
            int[] destArray = new int[2]; //being copied to...
            int startIndex = 0; //start at index 0
            int length = 2; //copy 2 integers from source which are 1 & 2

            Array.Copy(sourceArray, startIndex, destArray, startIndex, length);

            PrintArray(destArray, "Copied from Source to Dest Array");
            Console.WriteLine();
        }

        static void PrintArray(int[] randNums, string msg) //will display the message assigned in above PrintArray
        {
            foreach (int number in randNums)
            {
                Console.WriteLine($"{msg}: {number}");
            }
        }
    }
}
