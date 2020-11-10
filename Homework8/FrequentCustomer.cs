namespace Hwk8Heishman
{
    public class FrequentCustomer : Customer
    {
        private double discountRate;

        public double DiscountRate
        {
            get
            {
                return discountRate;
            }
            set
            {
                discountRate = value;
            }
        }
    }
}
