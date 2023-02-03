using NUnit.Framework.Constraints;
using System.ComponentModel.DataAnnotations;
using Test_Exercises;
using System;
using NUnit.Framework;

namespace BankAccTests
{

    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ChecksIfDepositZeroIsPossible()
        {
            BankAccaount acc = new BankAccaount();

            var ex = Assert.Throws<InvalidOperationException>(() => acc.Deposit(0));

            Assert.That(ex.Message, Is.EqualTo("You can not deposit less or equal to 0 money!"));
        }

        [Test]
        public void CheckIfDepositLessThanZeroIsPossible()
        {
            BankAccaount acc = new BankAccaount();

            var ex = Assert.Throws<InvalidOperationException>(() => acc.Deposit(-10));

            Assert.That(ex.Message, Is.EqualTo("You can not deposit less or equal to 0 money!"));

        }

        [Test]
        public void CheckNormalDeposit()
        {
            BankAccaount acc = new BankAccaount();

            acc.Deposit(10);
            acc.Deposit(101);

            Assert.That(111, Is.EqualTo(acc.Balance()), "Deposit does not work!");
        }

        [Test]
        public void CheckIfWithdraw0IsPossible()
        {
            BankAccaount acc = new BankAccaount();

            var ex = Assert.Throws<InvalidOperationException>(() => acc.Withdraw(0));

            Assert.That(ex.Message, Is.EqualTo("You can not withdraw less or equal to 0 money!"));
        }

        [Test]
        public void CheckIfWithdrawMoreThanYouHaveIsPossible()
        {
            BankAccaount acc = new BankAccaount();

            var ex = Assert.Throws<InvalidOperationException>(() => acc.Withdraw(10));

            Assert.That(ex.Message, Is.EqualTo("You don not have enough money to withdraw!"));
        }

        [Test]
        public void CheckNormalWithdraw()
        {
            BankAccaount acc = new BankAccaount();

            acc.Deposit(100);
            acc.Withdraw(99.99);
            double res = acc.Balance();
            Assert.That(res, Is.EqualTo(0.01), "Withdraw is not working!");
        }

        [Test]
        public void CheckDoubleBalance()
        {
            BankAccaount acc = new BankAccaount();

            acc.Deposit(22.345);

            Assert.That(acc.Balance(), Is.EqualTo(22.34), "Balance is not giving 22.34");
        }

        [Test]
        public void CheckNormalBalance()
        {
            BankAccaount acc = new BankAccaount();
            acc.Deposit(10);

            Assert.That(acc.Balance(), Is.EqualTo(10), "Balance is not 10");
        }

    }
}