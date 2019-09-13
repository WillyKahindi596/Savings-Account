using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccountQuestion01
{
     public abstract class Account
    {
        public double balance, newBalance, deposit, withdraw;

        public static double Deposit(double balance, double deposit)
        {
            return balance + deposit;
        }

        public static double Withdraw(double balance, double withdraw)
        {
            return (balance - withdraw);
        }
        public abstract double annualInterest();


    }

}
