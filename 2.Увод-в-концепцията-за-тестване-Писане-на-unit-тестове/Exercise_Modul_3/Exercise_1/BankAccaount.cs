using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Exercises
{
    public class BankAccaount
    {
        private double money;

        public BankAccaount(double money)
        {
            Money = money;
        }

        public BankAccaount() : this(0) { } 

        public double Money { get => money; set => money = value; }

        public void Deposit(double amount)
        {
            if (CheckIfLessOrEqualToZero(amount))
            {
                throw new InvalidOperationException("You can not deposit less or equal to 0 money!");
            }
            Money += amount;
        }

        public void Withdraw(double amount)
        {
            if (AvailableWithdraw(amount))
            {
                throw new InvalidOperationException("You don not have enough money to withdraw!");
            }
            if (CheckIfLessOrEqualToZero(amount))
            {
                throw new InvalidOperationException("You can not withdraw less or equal to 0 money!");
            }
            Money -= amount;
        }

        public double Balance()
        {
            return double.Parse($"{Money:F2}");
        }

        private bool AvailableWithdraw(double amount)
        {
            if(Money < amount)
            {
                return true;
            }
            return false;
        }

        private bool CheckIfLessOrEqualToZero(double amount)
        {
            if(amount <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
