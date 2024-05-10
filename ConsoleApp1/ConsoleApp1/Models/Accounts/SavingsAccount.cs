using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Accounts.Accounts
{
    public class SavingsAccount : Account
    {
        private const decimal MaxLimitInADay = 20000;

        public void Withdraw(decimal amount)
        {
            if (amount <= MaxLimitInADay) {
                Withdraw(amount);
            }
            else{
                Console.WriteLine($"CANNOT WITHDRAW MORE THAN {MaxLimitInADay}");
            }
        }
    }
}
