using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsAndVegetablesShop.Views
{
    public class Display
    {
        private double pricePerKiloV;
        private double pricePerKiloF;
        private double Vkilos;
        private double Fkilos;
        private double bill;

        public Display()
        {
            pricePerKiloV = 0;
            pricePerKiloF = 0;
            Vkilos = 0;
            Fkilos = 0;
            GetValues();
        }

        public double PricePerKiloV { get => pricePerKiloV; set => pricePerKiloV = value; }
        public double PricePerKiloF { get => pricePerKiloF; set => pricePerKiloF = value; }
        public double Vkilos1 { get => Vkilos; set => Vkilos = value; }
        public double Fkilos1 { get => Fkilos; set => Fkilos = value; }
        public double Bill { get => bill; set => bill = value; }

        public void GetValues()
        {
            Console.WriteLine("Enter price per kilos for the vegetables:");
            pricePerKiloV = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter price per kilos for the fruits:");
            pricePerKiloF = double.Parse(Console.ReadLine());
            Console.WriteLine("how many kilos of vegetables will you buy?");
            Vkilos = double.Parse(Console.ReadLine());
            Console.WriteLine("how many kilos of fruits will you buy?");
            Fkilos = double.Parse(Console.ReadLine());
        }

        public void ShowResult()
        {
            Console.WriteLine();
            Console.WriteLine($"Your bill is: {Bill}");
        }
    }
}
