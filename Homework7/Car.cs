namespace Hwk7Heishman
{
    public class Car
    {
        private string color;
        private int price;

        public Car() : this(10000, "black") //constructor initializers, default price & color
        {
        }
        public Car(int price) : this(price, "black") //added price & black as default color
        {
        }
        public Car(int price, string color)
        {
            //this should be price
            Price = price;
            Color = color;
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int Price
        {
            get
            {
                //return price
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
