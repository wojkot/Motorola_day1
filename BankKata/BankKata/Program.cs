using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Account myAccount = new Account();
            while (exit != true)
            {
                Console.WriteLine("Please select action: D - deposit, W - withdraw, E -exit.");
                string action = Console.ReadLine();
                if (action == "W")
                {
                    Console.WriteLine("Withdraw money: ");
                    decimal outputMoney = Convert.ToDecimal(Console.ReadLine());
                    myAccount.Withdraw(outputMoney);
                    myAccount.PrintStatement();
                }
                else if (action == "D")
                {
                    Console.WriteLine("Deposit money: ");
                    decimal inputMoney = Convert.ToDecimal(Console.ReadLine());
                    myAccount.Deposit(inputMoney);
                    myAccount.PrintStatement();
                }
                else if (action == "E")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Undefined action.");
                }

            }
        }
    }
}
