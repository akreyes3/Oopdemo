namespace ConsoleApp1.Models.Accounts
{
    public interface ICheckingAccount
    {
        void Deposit(string checkNumber, decimal amount);
    }
}