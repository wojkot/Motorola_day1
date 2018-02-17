using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Tests
{
    [TestClass()]
    public class TestClassTests
    {
        [TestMethod()]
        public void GetMessageTest()
        {
            string givenString = "Test message";

            Assert.AreEqual(givenString, TestClass.GetMessage());
        }
    }
}