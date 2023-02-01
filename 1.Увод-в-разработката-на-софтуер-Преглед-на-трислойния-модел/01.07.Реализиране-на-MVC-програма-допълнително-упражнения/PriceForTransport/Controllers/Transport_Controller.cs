using Price_For_Transport.Entities;
using Price_For_Transport.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_For_Transport.Controllers
{
    public class Transport_Controller
    {
        Display display;
        Taxi taxi;
        Bus bus;
        Train train;

        public Transport_Controller()
        {
            display = new Display();
             taxi = new Taxi(display.Kilometers, display.Time);
             bus = new Bus(display.Kilometers, display.Time);
             train = new Train(display.Kilometers, display.Time);

            if(train.CalculatePrice() > 0)
            {
                display.Money_needed = train.CalculatePrice();
            }
            else if (train.CalculatePrice() == 0 && bus.CalculatePrice() > 0)
            {
                display.Money_needed = bus.CalculatePrice();
            }
            else
            {
                display.Money_needed = taxi.CalculatePrice();
            }

            display.ShowResult();
        }
    }
}
