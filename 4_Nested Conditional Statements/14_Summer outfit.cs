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
            int temperature = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (time == "Morning")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (temperature >= 19 && temperature <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperature >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
            }
            else if (time == "Afternoon")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperature >= 19 && temperature <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temperature >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
            }
            else if (time == "Evening")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperature >= 19 && temperature <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperature >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
            }
        }
    }
}