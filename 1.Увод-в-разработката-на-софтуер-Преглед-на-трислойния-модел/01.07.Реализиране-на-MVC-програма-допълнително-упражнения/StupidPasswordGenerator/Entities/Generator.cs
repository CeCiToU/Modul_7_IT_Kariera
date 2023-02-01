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
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int a = 0; a < l; a++)
                    {
                        for (int b = 0; b < l; b++)
                        {
                            for (int c = 1; c <= n; c++)
                            {
                                if (c > i && c > j)
                                {
                                    char aa = (char)(a + 97);
                                    char bb = (char)(b + 97);
                                    string result = $"{i}{j}{aa}{bb}{c}";
                                    list.Add(result);
                                }
                            }
                        }
                    }
                }
            }
        }

        public List<string> Passwords { get => passwords; set => passwords = value; }
    }
}
