using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bank.Tests
{
    [TestClass]
    public class Bank_Test
    {
        [TestMethod]
        public void AddMoney_correct()
        {
            //assign
            int a = 100;
            float b = 2;
            BankAccount bankAccount = new BankAccount(a, b);
            //act
            bool c = bankAccount.AddMoney(100);
            //assert
            Assert.AreEqual(true, c);

        }

        [TestMethod]
        public void AddMoney_incorrect()
        {
            //assign
            int a = 100;
            float b = 2;
            BankAccount bankAccount = new BankAccount(a, b);
            //act
            bool c = bankAccount.AddMoney(-5);
            //assert
            Assert.AreEqual(false, c);

        }

        [TestMethod]
        public void BuySomething_correct()
        {
            //assign
            int a = 100;
            float b = 2;
            BankAccount bankAccount = new BankAccount(a, b);
            //act
            bool c = bankAccount.BuySomething(200,b);
            //assert
            Assert.AreEqual(true, c);

        }

        [TestMethod]
        public void BuySomething_incorrect()
        {
            //assign
            int a = 100;
            float b = 2;
            BankAccount bankAccount = new BankAccount(a, b);
            //act
            bool c = bankAccount.BuySomething(-200, b);
            //assert
            Assert.AreEqual(false, c);

        }

        [TestMethod]
        public void BuySomething_cashback_correct()
        {
            //assign
            int a = 100;
            float b = 2;
            BankAccount bankAccount = new BankAccount(a, b);
            //act
            bool c = bankAccount.BuySomething(50, b);
            //assert
            Assert.IsTrue(c && bankAccount.TotalMoney == 51);

        }
    }
}
