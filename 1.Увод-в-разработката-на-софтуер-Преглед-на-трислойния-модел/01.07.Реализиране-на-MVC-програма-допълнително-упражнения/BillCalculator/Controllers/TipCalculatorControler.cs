using BillCalculator.Entities;
using BillCalculator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator.Controllers
{
    class TipCalculatorControler
    {
        private Tip tip;
        private Display display;

        public TipCalculatorControler()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            
            display.Tip = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndTotal();
        }
    }
}
