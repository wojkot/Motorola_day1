using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.IO;

namespace BankKata.Tests
{
    [TestClass()]
    public class AccountTests
    {
        private object printStream;

        [TestMethod()]
        public void GetAccoountInfoTest()
        {
            string header=string.Format("DATE | AMOUNT | BALANCE{0}", Environment.NewLine);
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Console.SetError(sw);
                var result = sw;

                Account account = new Account();
                account.PrintStatement();

                Assert.AreEqual(header, result.ToString());
            }
            
        }

        [TestMethod]
        public void DepositTest()
        {
            decimal amount = 500;
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Console.SetError(sw);
                var result = sw;

                Account account = new Account();
                account.Deposit(amount);
                string header = string.Format("DATE | AMOUNT | BALANCE{0}", Environment.NewLine);
                string expectedResult = header + string.Format(DateTime.Now.ToShortDateString() + " | 500 | 500{0}", Environment.NewLine);
                account.PrintStatement();

                Assert.AreEqual(expectedResult, result.ToString());
            }
        }

        [TestMethod]
        public void WithdrawTest()
        {
            decimal amount = 500;
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Console.SetError(sw);
                var result = sw;

                Account account = new Account();
                account.Withdraw(amount);
                string header = string.Format("DATE | AMOUNT | BALANCE{0}", Environment.NewLine);
                string expectedResult = header + string.Format(DateTime.Now.ToShortDateString()+ " 10 /04/2014 | -500 | -500{0}", Environment.NewLine);
                account.PrintStatement();

                Assert.AreEqual(expectedResult, result.ToString());
            }
        }
    }
}