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
            double distance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine().ToLower();
            string output = Console.ReadLine().ToLower();

            double inputInMeters = 0;
            double result = 0;

            if (input == "m")
            {
                inputInMeters = distance;
            }
            else if (input == "mm")
            {
                inputInMeters = distance / 1000;
            }
            else if (input == "cm")
            {
                inputInMeters = distance / 100;
            }
            else if (input == "mi")
            {
                inputInMeters = distance / 0.000621371192;
            }
            else if (input == "in")
            {
                inputInMeters = distance / 39.3700787;
            }
            else if (input == "km")
            {
                inputInMeters = distance / 0.001;
            }
            else if (input == "ft")
            {
                inputInMeters = distance / 3.2808399;
            }
            else if (input == "yd")
            {
                inputInMeters = distance / 1.0936133;
            }


            if (output == "m")
            {
                result = inputInMeters;
            }
            if (output == "mm")
            {
                result = inputInMeters * 1000;
            }
            if (output == "cm")
            {
                result = inputInMeters * 100;
            }
            if (output == "mi")
            {
                result = inputInMeters * 0.000621371192;
            }
            if (output == "in")
            {
                result = inputInMeters * 39.3700787;
            }
            if (output == "km")
            {
                result = inputInMeters * 0.001;
            }
            if (output == "ft")
            {
                result = inputInMeters * 3.2808399;
            }
            if (output == "yd")
            {
                result = inputInMeters * 1.0936133;
            }
            Console.WriteLine($"{result:F8}");
        }
    }
}