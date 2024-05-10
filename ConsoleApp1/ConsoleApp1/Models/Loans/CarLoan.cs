
namespace ConsoleApp1.Models.Loans
{
    public class CarLoan : Loan
    {
        private string _carModel;

        public CarLoan(decimal amount, int duration, string carModel) : base (amount, 0.05, duration)
        { 
            _carModel = carModel;
        }

        public string Type => "Car Loan";

        public override void DisplayLoanDetails() 
        {
            Console.WriteLine($"Type of Loan: {Type}");
            Console.WriteLine($"{Type}Details:");
            Console.WriteLine($"Car Model: {_carModel}");
            Console.WriteLine($"Total Loan: {CalculateTotalPayment()}");
        }

    }
}
