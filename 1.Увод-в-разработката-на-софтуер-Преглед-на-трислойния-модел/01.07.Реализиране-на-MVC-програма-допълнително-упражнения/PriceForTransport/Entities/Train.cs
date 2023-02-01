using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_For_Transport.Entities
{
    public class Train
    {
        private int kilometers;
        private string time;
        private double price = 0.06;
        public Train(int kilometers, string time)
        {
            Kilometers = kilometers;
            this.time = time;
        }

        public double CalculatePrice()
        {
            if (kilometers > 100)
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
