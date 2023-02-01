using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_For_Transport.Entities
{
    public class Bus
    {
        private int kilometers;
        private string time;
        private double price = 0.09;
        public Bus(int kilometers, string time)
        {
            Kilometers = kilometers;
            this.time = time;
        }

        public double CalculatePrice()
        {
            if (kilometers > 20)
            {
                return this.Kilometers * this.price;
            }
            else
            {
                return 0;
            }
        }

        public int Kilometers { get => kilometers; set => kilometers = value; }
    }
}
