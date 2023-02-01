using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday.Views
{
    public class Display
    {
        private double budget;
        private string season;
        private string destination;
        private string bill;

        public Display()
        {
            Budget = 11;
            Season = "summer";
            Destination = "";
            Bill = "";
            GetValues();
        }

        public void GetValues()
        {
            Console.WriteLine("Your budget is:");
            Budget = double.Parse(Console.ReadLine());
            Console.WriteLine("Which season you want to have holiday in?");
            Season = Console.ReadLine();
        }

        public void ShowResult()
        {
            Console.WriteLine($"{Destination}");
            Console.WriteLine($"{Bill}");
        }

        public double Budget
        {
            get => budget;
            set
            {
                if (10.00 <= value && value <= 5000.00)
                {
                    budget = value;
                }
                else
                {
                    Console.WriteLine("Invalid budget entered!\nPlease enter budget between 10 and 5000!");
                    Budget = double.Parse(Console.ReadLine());
                }
            }
        }
        public string Season
        {
            get => season;
            set
            {
                if (value == "summer" || value == "winter")
                {
                    season = value;
                }
                else
                {
                    Console.WriteLine("Invalid season entered!\nPlease enter \"summer\" or \"winter\"");
                    Season = Console.ReadLine();
                }
            }
        }
        
        public string Bill { get => bill; set => bill = value; }
        public string Destination { get => destination; set => destination = value; }
    }
}
