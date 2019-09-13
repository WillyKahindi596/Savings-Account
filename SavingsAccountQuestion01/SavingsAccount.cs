using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccountQuestion01
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(double balance)
        {
            this.balance = balance;
        }
        public override double annualInterest()
        {
            return balance + (balance * 0.10);
        }
    }
}
