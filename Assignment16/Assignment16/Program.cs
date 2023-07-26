using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter Account holder name");
                string accountHolderName = Console.ReadLine();
                BankAccount account = new BankAccount(accountHolderName);
                Console.WriteLine("Enter the amount you want to deposit");
                double depAmount = Convert.ToDouble(Console.ReadLine());
                account.Deposit(depAmount);
                account.PrintAccountDetails();

                Console.WriteLine("Enter the amount you want to withdraw");
                double withdAmount = Convert.ToDouble(Console.ReadLine());  
                account.Withdraw(withdAmount); 
                account.PrintAccountDetails();
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format Exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown Error!!!" + e.Message);
                Console.ReadKey();
            }



        }
    }
}
