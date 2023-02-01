using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Passoword_Generator.Views
{
    public class Display
    {
        private int n;
        private int l;
        private List<string> passwords;

        public Display()
        {
            n = 0;
            l = 0;
            passwords = new List<string>();
            GetValues();
        }

        public List<string> Passwords { get => passwords; set => passwords = value; }
        public int N { get => n; set => n = value; }
        public int L { get => l; set => l = value; }

        public void GetValues() 
        {
            Console.Write("Enter the value of n: ");
            this.n = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of l: ");
            this.l = int.Parse(Console.ReadLine());
        }

        public void ShowResult()
        {
            int j = 9;
            Console.WriteLine("Generated passwords:");
            for(int i = 0; i < passwords.Count; i++)
            {
                if(i % j == 0 && i != 0)
                {
                    Console.WriteLine(passwords[i] + ", ");
                    j+= 10;
                }
                else if (i == passwords.Count - 1)
                {
                    Console.Write(passwords[i]);
                }
                else
                {
                    Console.Write(passwords[i] + ", ");
                }
            }
        }
    }
}
