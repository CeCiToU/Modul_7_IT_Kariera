using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devider.Models
{
    public class PercentCalculator
    {
        private List<int> numbers;
        private double p1;
        private double p3;
        private double p2;

        public PercentCalculator(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public double P1 { get => p1; set => p1 = value; }
        public double P3 { get => p3; set => p3 = value; }
        public double P2 { get => p2; set => p2 = value; }

        public void CalculatePercentage()
        {
            double p1p = 0;
            double p2p = 0;
            double p3p = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    p1p++;
                }
                if (numbers[i] % 3 == 0)
                {
                    p2p++;
                }
                if (numbers[i] % 4 == 0)
                {
                    p3p++;
                }
            }
            p1 = p1p * 100 / numbers.Count;
            p2 = p2p * 100 / numbers.Count;
            p3 = p3p * 100 / numbers.Count;
        }

    }
}
