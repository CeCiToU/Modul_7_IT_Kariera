using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devider.Views
{
    public class Display
    {
        private int n;
        private List<int> numbers;
        private double p1;
        private double p2;
        private double p3;

        public List<int> Numbers { get => numbers; set => numbers = value; }
        public double P1 { get => p1; set => p1 = value; }
        public double P2 { get => p2; set => p2 = value; }
        public double P3 { get => p3; set => p3 = value; }

        public Display()
        {
            n = 0;
            numbers = new List<int>();
            P1 = 0;
            p2 = 0;
            p3 = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("How many numbers will you insert?");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter numbers: ");
            numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
        }

        public void ShowResult()
        {
            Console.WriteLine($"p1 = {P1:F2}%");
            Console.WriteLine($"p2 = {p2:F2}%");
            Console.WriteLine($"p3 = {p3:F2}%");
        }
    }
}
