using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccountQuestion01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New Balance after Deposit: $" + Account.Deposit(100, 50));
            Console.WriteLine("New Balance after Withdraw: $" + Account.Withdraw(100, 50));

            SavingsAccount s1 = new SavingsAccount(100);
            Console.WriteLine("New Balance after Annual Interest: $" + s1.annualInterest());

            Console.ReadLine();
            
        }
        
    }
}
