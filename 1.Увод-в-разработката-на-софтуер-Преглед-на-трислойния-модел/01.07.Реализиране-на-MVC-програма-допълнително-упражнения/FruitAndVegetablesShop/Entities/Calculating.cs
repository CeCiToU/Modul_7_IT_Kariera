using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsAndVegetablesShop.Entities
{
    public class Calculating
    {
        private double pricePerKiloV;
        private double pricePerKiloF;
        private double Vkilos;
        private double Fkilos;
        private double bill;

        public Calculating(double ppkv, double ppkf, double vk, double fk)
        {
            PricePerKiloV = ppkv;
            PricePerKiloF = ppkf;
            Vkilos1 = vk;
            Fkilos1 = fk;
        }

        public void CalculatingBill()
        {
            bill += Vkilos1 * pricePerKiloV;
            bill += Fkilos1 * pricePerKiloF;
            bill /= 1.94;
        }

        public double PricePerKiloV { get => pricePerKiloV; set => pricePerKiloV = value; }
        public double PricePerKiloF { get => pricePerKiloF; set => pricePerKiloF = value; }
        public double Vkilos1 { get => Vkilos; set => Vkilos = value; }
        public double Fkilos1 { get => Fkilos; set => Fkilos = value; }
        public double Bill { get => bill; set => bill = value; }
    }
}
