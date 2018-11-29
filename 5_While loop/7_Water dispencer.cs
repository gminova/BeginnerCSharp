using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waterDispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupVolume = int.Parse(Console.ReadLine());
            int totalVolume = 0;
            int counter = 0;
            while (totalVolume < cupVolume)
            {
                string option = Console.ReadLine();
                if (option == "Easy")
                {
                    totalVolume = 50 + totalVolume;
                }
                else if (option == "Medium")
                {
                    totalVolume = 100 + totalVolume;
                }
                else if (option == "Hard")
                {
                    totalVolume = 200 + totalVolume;
                }
                counter = counter + 1;
            }
            if (totalVolume > cupVolume)
            {
                Console.WriteLine($"{totalVolume - cupVolume}ml has been spilled.");
            }
            else
            {
                Console.WriteLine($"The dispenser has been tapped {counter} times.");
            }
        }
    }
}