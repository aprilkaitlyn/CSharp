using System;

namespace Ch9Lecture
{
    public class Animal
    {
        public string name;
        public string sound;
        static int numberOfAnimals = 0; //static = can access without an instance of the Animal class

        //default constructor, if no variables are declared in the main class
        public Animal()
        {
            name = "no name";
            sound = "no sound";
            numberOfAnimals++;
        }

        //if no sound variable is declared
        public Animal(string name) 
        {
            this.name = name;
            this.sound = "no sound";
            numberOfAnimals++; //each time a new animal is instantiated it's added to the total number of animals
        }

        public Animal(string name = "no name", string sound = "no sound")
        {
            this.name = name;
            this.sound = sound;
            numberOfAnimals++;
        }

        public void MakeSound() //a method all Animals can use
        {
            Console.WriteLine($"{name} says {sound}!");
            Console.WriteLine($"There are {getNumAnimals()} animals");
        }

        public static int getNumAnimals()
        {
            return numberOfAnimals;
        }

        public override string ToString()
        {
            return string.Format($"This animal's name is {name} and its sound is {sound}");
        }
    }
}
