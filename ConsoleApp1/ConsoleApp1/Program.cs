using ConsoleApp1.Models;
using ConsoleApp1.Models.Accounts;
using ConsoleApp1.Models.Loans;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var accountHolder = new AccountHolder("JDELACRUZ", new CheckingAccount());


            var newCarLoan = new CarLoan(2000000, 36, "GR86");
            var newPersonalLoan = new PersonalLoan(1000000,360, "Renovate");

            accountHolder.Loans.Add(newCarLoan);
            accountHolder.Loans.Add(newPersonalLoan);

            accountHolder.DisplayLoansDetails();



            //var checkingAccount = (ICheckingAccount)accountHolder.Account;

            //if (checkingAccount != null)
            //{
            //    checkingAccount.Deposit("asdadads", 10000);
            //}
            ////accountHolder.Account.Deposit("meow", 10000);
            /////
            ////if (accountHolder.Account is ICheckingAccount checkingAccount)
            //accountHolder.Account.Withdraw(25000);

            //var balance = accountHolder.Account.GetBalance();

            //Console.WriteLine(balance);

            //Console.WriteLine($"AccountNumber {accountHolder.Account.AccountNumber:n}");

            //var account = new Account();

            //account.Deposit(50000);
            //account.Withdraw(20000);
            //account.GetBalance();

            //var balance = account.GetBalance();

            //Console.WriteLine($"My balance is {balance:n}");
            //Console.ReadLine();

            //var loan = new Loan();
            //loan.CalculateTotalPayment();
            //loan.DisplayLoanDetails();

            //Console.WriteLine($"My balance is {totalPayment:n}");
            //Console.ReadLine();
        }
    }
}