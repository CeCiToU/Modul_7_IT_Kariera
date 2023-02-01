using FruitsAndVegetablesShop.Entities;
using FruitsAndVegetablesShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsAndVegetablesShop.Controllers
{
    public class ShopController
    {
        Display display;
        Calculating calc;

        public ShopController()
        {
            display = new Display();
            calc = new Calculating(display.PricePerKiloV, display.PricePerKiloF, display.Vkilos1, display.Fkilos1);
            calc.CalculatingBill();
            display.Bill = calc.Bill;
            display.ShowResult();
        }
    }
}
