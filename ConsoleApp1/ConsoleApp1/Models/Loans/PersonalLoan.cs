
namespace ConsoleApp1.Models.Loans
{
    public class PersonalLoan : Loan
    {
        private string _purpose;
        public PersonalLoan(decimal amount, int duration, string purpose): base(amount, 0.03, duration) 
        {
            _purpose = purpose;
        }

        public string Type => "Personal Loan";

        public override void DisplayLoanDetails()
        {
            Console.WriteLine($"Type of Loan: {Type}");
            Console.WriteLine($"{Type}Details:");
            Console.WriteLine($"Purpose of Loan: {_purpose}");
            Console.WriteLine($"Total Loan: {CalculateTotalPayment()}");
        }
    }
}
