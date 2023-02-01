using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Passoword_Generator.Entities
{
    public class Generator
    {
        int n;
        int l;
        List<string> passwords;

        public Generator(int n, int l)
        {
            this.n = n;
            this.l = l;
            passwords = new List<string>();
        }

        public void GeneratePasswords()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        for (int m = 0; m < l; m++)
                        {
                            passwords.Add(i.ToString() + i.ToString() + (char)('a' + k) + (char)('a' + m) + j.ToString());
                        }
                    }
                }
            }
        }

        public List<string> Passwords { get => passwords; set => passwords = value; }
    }
}
