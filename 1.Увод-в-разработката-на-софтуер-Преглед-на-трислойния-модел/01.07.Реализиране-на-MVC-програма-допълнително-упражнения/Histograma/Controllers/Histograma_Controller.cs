using Histograma.Views;
using Histograma.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histograma.Controllers
{
    class Histograma_Controller
    {
        Display display;
        P p;

        public Histograma_Controller()
        {
            display = new Display();
            p = new P(display.Numbers);
            p.CalculatePercent();
            display.P1 = p.P1;
            display.P2 = p.P2;
            display.P3 = p.P3;
            display.P4 = p.P4;
            display.P5 = p.P5;

            display.ShowResult();
        }
    }
}
