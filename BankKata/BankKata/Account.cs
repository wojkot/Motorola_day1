using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata
{
    public class Account
    {
        List<string> operationsLogs = new List<string>();
        decimal actualValue = 0;

        public Account()
        {
            operationsLogs.Add("DATE | AMOUNT | BALANCE");
        }
        public void PrintStatement()
        {
            operationsLogs.Reverse(1, operationsLogs.Count-1);
            foreach (string log in operationsLogs)
            {
                Console.WriteLine(log);
            }
           
        }

        public void Deposit( decimal amount)
        {
            actualValue += amount;
            operationsLogs.Add($"{DateTime.Now.ToShortDateString()} | {amount} | {actualValue}");
        }

        public void Withdraw(decimal amount)
        {
            actualValue -= amount;
            operationsLogs.Add($"{DateTime.Now.ToShortDateString()} | {-amount} | {actualValue}");
        }
    }
}
