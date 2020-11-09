using System;

namespace Ch10Lecture //inheritance!!!
{
    class Program
    {
		/* 
		Inheritance allows you to define a child class that reuses (inherits), extends, or modifies the behavior of a parent class. 
		The class whose members are inherited is called the base class. 
		The class that inherits the members of the base class is called the derived class		
		*/

        static void Main(string[] args)
        {

			// EXTENDING CLASSES (Inheritance)
			var employee = new Employee();
			employee.DoWork();
			Console.WriteLine();

			// Base Class = Employee
			// Base Class = Parent Class = SuperClass
			// Extended Class = SoftwareDeveloper
			// Entended Class = Child Class = Subclass

			var dev = new SoftwareDeveloper();
			dev.DoWork(); //dev can access DoWork from Employee
			dev.WriteCode(); //dev can access WriteCode from SoftwareDeveloper
			Console.WriteLine();


			// *************************************** Part 2 *************************************** 

			/*Overriding Base Class Members
					Override -	Required to extend or modify the abstract or virtual implementation of an
			                    inherited method, property, indexer, or event. (CHILD CLASS)
					Virtual  -	Used to modify a method, property, indexer, or event declaration 
								and allow for it to be overridden in a derived class. 
								For example, this method can be overridden by any class that inherits it
								When a virtual method is invoked, the run-time type of the object
			                    is checked for an overriding member (PARENT CLASS)
			   You cannot override a non-virtual or static method. 
			*/

			var auto = new Auto
			{
				Make = "Mini",
				Model = "Cooper",
				Year = 2021,
			};

			auto.Drive();

			var truck = new Truck()
			{
				Make = "Toyota", //make, model, and year all from parent Auto class
				Model = "Tundra",
				Year = 2004,
				TowingCapacity = 1000 //unique to truck child class
			};

			truck.Drive();
			truck.Tow();

			Console.WriteLine("***************");

			DoDrive(auto); //another way to get the same console output
			DoDrive(truck);

		}

		private static void DoDrive(Auto a)
		{
			a.Drive();
		}

	}

	class Auto
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }

		public virtual void Drive() //add virtual so the child Truck class can override this method!
		{
			Console.WriteLine($"The {Year} {Make} {Model} is driving.");
		}
	}

	class Truck : Auto
	{
		public int TowingCapacity { get; set; }
		public int CargoSize { get; set; }

		public override void Drive() //overrides the Drive method from the parent Auto class
		{
			Console.WriteLine($"The {Year} {Make} {Model} is hauling.");
		}

		public void Tow()
		{
			Console.WriteLine($"Now we're towing {TowingCapacity} pounds!");
		}
	}

	internal class Employee //parent or base class
	{
		public Employee()
        {

        }

		public void DoWork()
		{
			Console.Write("Working");
            Console.WriteLine();
		}
	}

	internal class SoftwareDeveloper : Employee //child class -- child : parent is how you extend a class in C#
    {
		public SoftwareDeveloper()
        {

        }

		public void WriteCode()
        {
            Console.WriteLine("Writing C# code!");
            Console.WriteLine();
        }
    }
}
