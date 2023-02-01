using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histograma.Views
{
    public class Display
    {
        private int n;
        private List<int> numbers;
        private double p1;
        private double p2;
        private double p3;
        private double p4;
        private double p5;

        public Display()
        {
            n = 0;
            numbers = new List<int>();
            p1 = 0;
            p2 = 0;
            p3 = 0;
            p4 = 0;
            p5 = 0;
            GetValues();
        }

        public List<int> Numbers { get => numbers; set => numbers = value; }
        public double P1 { get => p1; set => p1 = value; }
        public double P2 { get => p2; set => p2 = value; }
        public double P3 { get => p3; set => p3 = value; }
        public double P4 { get => p4; set => p4 = value; }
        public double P5 { get => p5; set => p5 = value; }

        public void GetValues() 
        {
            Console.WriteLine("Hoq many numbers will you insert?");
            this.n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                switch(i)
                {
                    case 0:
                        Console.WriteLine("Enter number:");
                        numbers.Add(int.Parse(Console.ReadLine()));
                        break;
                    default:

                        Console.WriteLine("Next number:");
                        numbers.Add(int.Parse(Console.ReadLine()));
                            break;
                }
                
            }
            
        }

        public void ShowResult()
        {
            Console.WriteLine($"\n\np1 = {p1:F2}%\np2 ={p2:F2}%\np3 = {p3:F2}%\np4 = {p4:F2}%\np5 = {p5:F2}%\n");
        }
    }
}
