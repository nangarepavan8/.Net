using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oops
{
    public class BankAccount
    {
        public string Number { get; }

        public string Owner { get; set; }

        public decimal Balance {
            get
            {
                decimal balance = 0;
                   
                foreach (var item in allTransaction)
                {
                    balance = balance + item.Amount;
                }
                return balance;
            }
        }

        // take user input 
        public decimal amount { get; set; }



        private static int AccountNumberSeed = 1;

        private List<Transaction> allTransaction = new List<Transaction>();


        // name balance and account number
        public BankAccount(string name , decimal initialBalance)
        {
            this.Owner = name;

            // this.Balance = initialBalance;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance"); 
            
            this.Number = AccountNumberSeed.ToString();
            AccountNumberSeed++;


        }


        public void MakeDeposit(decimal  amount, DateTime date,  string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount the deposite must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            allTransaction.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount , DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount the deposite must be positive");
                // throw new InvalidOperationException("Not sufficient funds to Withdrawal ");
            }

            if( Balance - amount <= 0 )
            {
                throw new InvalidOperationException("Not sufficient funds to Withdrawal ");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransaction.Add(withdrawal);
            allTransaction.OrderByDescending();


       public string GetAccountHistory()
        {
            var report = new StringBuilder();

            //HEADER
            report.AppendLine("Date \t Amount \t Note");

            foreach(var item in allTransaction)
            {
                //ROWS
                report.AppendLine($"{item.Date} \t {item.Amount} \t {item.Notes}" );
            }

            return report.ToString();

        }
    }
}
