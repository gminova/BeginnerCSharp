using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationCost = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int counter = 0;
            int days = 0;
            do
            {
                string command = Console.ReadLine();
                double transfer = double.Parse(Console.ReadLine());
                days++;
                if (command == "spend")
                {
                    money -= transfer;
                    counter++;
                    if (transfer >= money)
                    {
                        money = 0;
                    }
                    if (counter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                }
                else if (command == "save")
                {
                    money += transfer;
                    counter = 0;
                }
                if (vacationCost <= money)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            } while (money < vacationCost);

        }
    }
}