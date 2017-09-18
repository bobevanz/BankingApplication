using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class Program
    {
        public class Account
        {
            public double balance;
            public Account()
            {
                balance = 500.00;
            }


            public void Deposit()
            {
                double NewBalance;
                double deposit;
                Console.WriteLine("Please enter amount to deposit");
                deposit = Double.Parse(Console.ReadLine());
                NewBalance = balance + deposit;
                return NewBalance;
            }

            public void Withdrawl()
            {
                double NewBalance;
                double withdrawal;
                Console.WriteLine("Please enter amount to withdrawal");
                withdrawal = Double.Parse(Console.ReadLine());
                NewBalance = balance - withdrawal;
                return NewBalance;
            }

            public double CheckBalance()
            {

            }
            static void Main(string[] args)
            {
                double NewBalance;
                string balance;
                Account bank = new Account();

                Console.WriteLine("Current balance is 500.00");
                Console.WriteLine("Press d for deposit or press w for withdrawal");

                balance = Console.ReadLine();

                if(balance == "d")
                {
                    NewBalance = bank.Deposit();

                    Console.WriteLine("Your new balance is{0}", NewBalance);
                }
                if (balance == "w")
                {
                    NewBalance = bank.Withdrawl();
                    Console.WriteLine("Your new balance is{0}", NewBalance);
                }

                Console.ReadLine();
            }
        }
    }
}
