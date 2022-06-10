using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount("Pavan", 5000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} and  Account Balance is {account.Balance}");

            account.MakeDeposit(500, DateTime.Now, "personal use") ;
           // account.MakeDeposit( DateTime.Now, "personal use");
            Console.WriteLine($"You are deposited Amount {account.amount} aand remaining balance is  {account.Balance} .");

            account.MakeWithdrawal(1000, DateTime.Now, "Bike");
            Console.WriteLine($"You are Withdrawal {account.Balance} Amount");

            Console.WriteLine(account.GetAccountHistory());



            account.MakeDeposit(-500, DateTime.Now, "personal use");
        }
    }
}
