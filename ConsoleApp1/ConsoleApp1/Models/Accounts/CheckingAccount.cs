using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Accounts
{
    public class CheckingAccount : Account, ICheckingAccount
    {

        public void Deposit(string checkNumber, decimal amount)
        {
            base.Deposit(amount);
            Console.WriteLine($"Deposited: {amount:n}");
        }
    }
}
