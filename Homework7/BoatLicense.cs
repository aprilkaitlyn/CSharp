namespace Hwk7Heishman
{
    public class BoatLicense
    {
        public string State;
        public int MotorSizeInHP;
        public string LicenseNum;
        public double price;

        public int motor
        {
            get { return MotorSizeInHP; }
            set
            {
                MotorSizeInHP = value;
                getPrice();
            }
        }

        public double getPrice() 
        {
            if (motor <= 50)
                price = 25;
            else if (motor <= 100)
                price = 38;
            else
                price = 50;
            return price;
        }
    }
}
