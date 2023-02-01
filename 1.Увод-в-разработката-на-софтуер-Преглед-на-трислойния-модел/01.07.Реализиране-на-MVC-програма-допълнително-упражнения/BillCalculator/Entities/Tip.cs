using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator.Entities
{
     public class Tip
     {
        private double amount;
        private double percent;

        public Tip(double amount, double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }

        public Tip() : this (0,0) { }

        public double Amount { get => amount; set => amount = value; }
        public double Percent { get { return percent; } set { percent = value; } }

        public double CalculateTip() 
        {
            return Amount * Percent / 100;
        }

        public double CalculateTotal() 
        {
            return CalculateTip() + this.Amount;
        }
    }
}
