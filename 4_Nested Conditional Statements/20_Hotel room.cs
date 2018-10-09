using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double costApartment = 0.0;
            double costStudio = 0.0;
            double totalCostApartment = 0.0;
            double totalCostStudio = 0.0;
            switch (month)
            {
                case "May":
                case "October": costApartment = 65; costStudio = 50; break;
                case "June":
                case "September": costApartment = 68.70; costStudio = 75.20; break;
                case "July":
                case "August": costApartment = 77; costStudio = 76; break;
            }
            totalCostApartment = days * costApartment;
            totalCostStudio = days * costStudio;
            if (days > 7 && days <= 14)
            {
                if (month == "May" || month == "October")
                {
                    totalCostStudio = days * costStudio * 0.95;
                }
            }
            else if (days > 14)
            {
                totalCostApartment = days * costApartment * 0.90;
                if (month == "May" || month == "October")
                {
                    totalCostStudio = days * costStudio * 0.70;
                }
                else if (month == "June" || month == "September")
                {
                    totalCostStudio = days * costStudio * 0.80;
                }
            }
            Console.WriteLine($"Apartment: {totalCostApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalCostStudio:f2} lv.");
        }
    }
}
