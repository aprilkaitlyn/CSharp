namespace Hwk8Heishman
{
    public class Customer
    {
        private int custNum;
        private double custBalance;

        public Customer () //added empty constructor
        {

        }

        public int CustNum //made public
        {
            get
            {
                return custNum;
            }
            set
            {
                custNum = value;
            }
        }
        public double CustBal
        {
            get
            {
                return custBalance;
            }
            set
            {
                custBalance = value; //changed to =
            }
        }

    }
}
