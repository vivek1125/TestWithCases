using System;

namespace TestWithCases
    {
    public class VivekBank
    {
        private string customerName;
        private double balance;

        private VivekBank() { }

        public VivekBank(string cname, double bal)
        {
            customerName = cname;
            balance = bal;
        }

        public string CustomerName
        {
            get { return customerName; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Debit(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            balance -= amount; // intentionally incorrect code
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            balance += amount;
        }

        public static void Main()
        {
            VivekBank vb = new VivekBank("Vivek Raj", 14.56);
            vb.Credit(12.56);
            vb.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", vb.Balance);
        }
    }
}
