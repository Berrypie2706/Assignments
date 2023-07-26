using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    public class BankAccount
    {
        private static int nextAccountNumber =100;
       


        public int AccountNumber { get; }
        public string AccountHolderName { get; }
        private double Balance { get; set; }

        public BankAccount(String accountHolderName)
        {
            AccountNumber= nextAccountNumber++;
            AccountHolderName = accountHolderName;

            Balance = 0;

        }

        public void Deposit(double depositAmount)
        {
           
            if (depositAmount <= 0)
            {
                throw new ArgumentException("Deposit must be greater than zero");
            }
            else
            {
                Balance += depositAmount;
            }
           
            
        }

        public void Withdraw( double amount)
        {
            if(amount>Balance )
            {
                Console.WriteLine("Insufficient Balance");
            }
            if(amount<=0)
            {
                Console.WriteLine("Withdrwal must be greater than zero");
            }
            Balance -=amount;
            Console.WriteLine("Withdrawl successfully!!!");
        }
        public void PrintAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder Name: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine();
        }
    }
}
