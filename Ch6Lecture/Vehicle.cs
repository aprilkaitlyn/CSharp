using System;
using System.Collections.Generic;
using System.Text;

namespace Ch6Lecture
{
    class Vehicle
    {

        // Vehicle properties
        public string Brand { get; set; }

        // Properties and methods from
        // the interface
        public double Speed { get; set; }
        public int Wheels { get; set; }

        //Constructor
        public Vehicle(string brand = "No Brand",
                int wheels = 0,
                double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }


        public void Move()
        {
            Console.WriteLine($"The {Brand} Moves Forward at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} Stops");
            Speed = 0;
        }
    }
}
