using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_For_Transport.Entities
{
    public class Taxi
    {
        private int kilometers;
        private string time;
        private double day_price = 0.79;
        private double night_price = 0.90;
        public Taxi(int kilometers, string time)
        {
            Kilometers = kilometers;
            this.time = time;
        }

        public double CalculatePrice()
        {
            if(time == "day")
            {
                return 0.70 + this.kilometers * 0.79;

            }
            else
            {
                return 0.70 + this.kilometers * 0.90;
            }
        }


        public int Kilometers { get => kilometers; set => kilometers = value; }
    }
}
