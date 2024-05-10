
namespace ConsoleApp1.Models.Accounts
{
    public class Account
    {
        private decimal _balance; //field

        public Account()
        {
            AccountNumber = Guid.NewGuid();
        } //constructor

        public Guid AccountNumber { get; }
        public string Type { get; }
        public void Deposit(decimal amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited: {amount:n}");
        }
       
        public void Withdraw(decimal amount)
        {

            if (amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:n}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
