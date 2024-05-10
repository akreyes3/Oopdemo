using ConsoleApp1.Models.Accounts;
using ConsoleApp1.Models.Loans;

namespace ConsoleApp1.Models
{
    public class AccountHolder
    {
        public AccountHolder(string name, Account account)
        {
            AccountName = name;
            Account = account;
            Loans = [];
        }
        public string AccountName { get; }

        public Account Account { get; }

        public List<Loan> Loans { get; }

        public void DisplayLoansDetails() 
        { 
            foreach (Loan loan in Loans) 
            
            { 
                loan.DisplayLoanDetails();
            }
        }
    }

    
}
