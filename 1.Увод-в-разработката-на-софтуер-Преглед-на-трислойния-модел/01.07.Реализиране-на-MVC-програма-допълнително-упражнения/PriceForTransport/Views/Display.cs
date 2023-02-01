using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_For_Transport.Views
{
    public class Display
    {
        private int kilometers;
        private string time;
        private double money_needed;

        public Display()
        {
            Kilometers = 1;
            Time = "day";
            money_needed = 0;
            GetValues();
        }

        

        public void GetValues() {
            Console.WriteLine("How much kilometers will you travel?");
            Kilometers = int.Parse(Console.ReadLine());
            Console.WriteLine("What time will you travel?");
            Time = Console.ReadLine();
        }

        public void ShowResult() 
        {
            Console.WriteLine($"You will need {money_needed:F2} leva to travel {Kilometers} kilometers during {Time}");
        }

        public int Kilometers 
        {
            get => kilometers; 
            set 
            { 
            if(value > 0 && value < 5001)
                {
                    this.kilometers = value;
                }
            else
                {
                    Console.WriteLine("Invalid amount of kilometers! Please add number between 1 and 5000!");
                    Kilometers = int.Parse(Console.ReadLine());
                }
            } }
        public string Time { get => time;
            set 
            {
                if(value == "day" || value == "night")
                {
                    time = value;
                }
                else
                {
                    Console.WriteLine("Invalid time added! Please choose between day and night!");
                    Time = Console.ReadLine();
                }
            } }

        public double Money_needed { get => money_needed; set => money_needed = value; }
    }
}
