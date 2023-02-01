using Stupid_Passoword_Generator.Entities;
using Stupid_Passoword_Generator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Passoword_Generator.Controllers
{
    public class GeneratorController
    {
        Display display;
        Generator generator;
        public GeneratorController()
        {
            display = new Display();
            generator = new Generator(display.N, display.L);
            generator.GeneratePasswords();
            display.Passwords = generator.Passwords;
            display.ShowResult();
        }
    }
}
