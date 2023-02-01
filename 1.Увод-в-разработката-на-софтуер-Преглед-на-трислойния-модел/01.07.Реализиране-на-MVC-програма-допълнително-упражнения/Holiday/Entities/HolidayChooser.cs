using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday.Entities
{
    public class HolidayChooser
    {
        private double budget;
        private string season;
        private string destination;
        private string holidayType;
        private string bill;

        public HolidayChooser(double budget, string season)
        {
            this.budget = budget;
            this.season = season;
            this.destination = "";
            this.holidayType = "";
            this.bill = "";
        }

        public double Budget { get => budget; set => budget = value; }
        public string Season { get => season; set => season = value; }
        public string Destination { get => destination; set => destination = value; }
        public string HolidayType { get => holidayType; set => holidayType = value; }
        public string Bill { get => bill; set => bill = value; }

        public void ChooseVacation()
        {
            if (budget <= 100)
            {
                this.destination = "Somewhere in Bulgaria";
                this.Bill = BillCalculator(30, 70);
            }
            else if (budget <= 1000)
            {
                this.destination = "Somewhere in Balkans";
                this.Bill = BillCalculator(40, 80);
            }
            else if (budget > 1000)
            {
                this.destination = "Somewhere in Europe";
                this.Bill = BillCalculator(90, 90);
            }
        }

        private string BillCalculator(double percentS, double percentW)
        {
            if (this.season == "summer")
            {
                double bill = this.budget * percentS / 100;
                return this.HolidayType = $"Camp - {bill:F2}";
            }
            else
            {
                double bill = this.budget * percentW / 100;
                return this.HolidayType = $"Hotel - {bill:F2}";
            }

        }
    }
}
