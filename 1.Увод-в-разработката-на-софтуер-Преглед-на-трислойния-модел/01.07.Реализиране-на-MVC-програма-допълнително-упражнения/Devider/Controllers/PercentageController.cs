using Devider.Models;
using Devider.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devider.Controllers
{
    public class PercentageController
    {
        Display display;
        PercentCalculator calc;

        public PercentageController()
        {
            display = new Display();
            calc = new PercentCalculator(display.Numbers);
            calc.CalculatePercentage();
            display.P1 = calc.P1;
            display.P2 = calc.P2;
            display.P3 = calc.P3;
            display.ShowResult();
        }
    }
}
