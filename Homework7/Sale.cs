namespace Hwk7Heishman
{
    public class Sale
    {

        private string inv;
        private double amount;
        private double tax;

        public string InvNum
        {
            get { return inv; }
            set { inv = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value;
                  getTax(); } //get the amount, then calculate it's tax
        }

        public double getTax()
        {
            if (amount <= 100)
                tax = amount * 0.08;
            else
                tax = ((amount - 100) * 0.06) + 8; //$8 tax on first $100, then additional amount
            return tax;
        }
 
    }
}
