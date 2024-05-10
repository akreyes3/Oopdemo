
namespace ConsoleApp1.Models.Loans
{
    public class Loan
    {
        private decimal _amount;
        private double _interestRate;
        private int _duration;

        public Loan() : this(0, 0, 0)
        {
            // constructor chaining
            //to always set
        }

        public Loan(decimal amount, double interestRate, int duration)
        {
            _amount = amount; ;
            _interestRate = interestRate;
            _duration = duration;
        }

        public string Type { get; }

        public virtual decimal CalculateTotalPayment()
        {
            return _amount * (decimal)Math.Pow(1 + _interestRate, _duration);
        }
        public virtual void DisplayLoanDetails()
        {
            Console.WriteLine($"Amount: {_amount:n}");

            Console.WriteLine($"Interest rate: {_interestRate:n}");

            Console.WriteLine($"Duration: {_duration:n}");
        }
    }
}
