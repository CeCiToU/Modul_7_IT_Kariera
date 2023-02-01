using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator.Views
{
    public class Display
    {
        private double percent;
        private double amount;
        private double tip;
        private double total;

        public Display()
        {
            Percent = 0;
            Amount = 0;
            Tip = 0;
            Total = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("Your bill is: ");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Tip percent: ");
            Percent = double.Parse(Console.ReadLine());
        }

        public void ShowTipAndTotal() 
        {
            Console.WriteLine($"Your tip is {Tip:F2}");
            Console.WriteLine($"Your total bill is {Total:F2}");
        }



        public double Percent { get => percent; set => percent = value; }
        public double Amount { get => amount; set => amount = value; }
        public double Tip { get => tip; set => tip = value; }
        public double Total { get => total; set => total = value; }



    }
}
