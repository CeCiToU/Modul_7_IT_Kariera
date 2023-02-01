using Holiday.Entities;
using Holiday.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday.Controllers
{
    public class HolidayController
    {
        Display display;
        HolidayChooser holiday;

        public HolidayController()
        {
            display = new Display();
            holiday = new HolidayChooser(display.Budget, display.Season);
            holiday.ChooseVacation();
            display.Destination += holiday.Destination;
            display.Bill = holiday.Bill;
            display.ShowResult();
        }
    }
}
