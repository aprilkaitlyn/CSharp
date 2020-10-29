using System;

namespace Hwk7Heishman
{
    public class Room
    {
        public int Length;
        public int Width;
        public int Height;
        public double Area;
        public int Gallons;
        const int ONE_GALLON = 350; //350 sq ft = 1 gallon of paint
          

        public Room(int len, int wid, int hi) { //rooms will always have these 3 dimensions

            Length = len;
            Width = wid;
            Height = hi;

            Area = (2 * Length * Height) + (2 * Height * Width); //calculate wall area
            if (Area <= 350)
                Gallons = 1;
            else Gallons = (int)Math.Ceiling(Area / ONE_GALLON); //determine gallons
        }

    }
}
