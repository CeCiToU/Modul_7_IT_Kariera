using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histograma.Entities
{
    public class P
    {
        private List<int> numbers;
        private double p1;
        private double p2;
        private double p3;
        private double p4;
        private double p5;

        public P(List<int> l)
        {
            numbers = l;
        }

        public double P1 { get => p1; set => p1 = value; }
        public double P2 { get => p2; set => p2 = value; }
        public double P3 { get => p3; set => p3 = value; }
        public double P4 { get => p4; set => p4 = value; }
        public double P5 { get => p5; set => p5 = value; }

        public void CalculatePercent() 
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int num = numbers[i];
                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num < 400)
                {
                    p2++;
                }
                else if (num >= 400 && num < 600)
                {
                    p3++;
                }
                else if (num >= 600 && num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            p1 = p1 / numbers.Count * 100;
            p2 = p2 / numbers.Count * 100;
            p3 = p3 / numbers.Count * 100;
            p4 = p4 / numbers.Count * 100;
            p5 = p5 / numbers.Count * 100;
        }
    }
}
