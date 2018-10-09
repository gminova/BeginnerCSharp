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
            string figure = Console.ReadLine();
            string square = "square", rectangle = "rectangle",
                circle = "circle", triangle = "triangle";
            if (figure == square)
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == rectangle)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == circle)
            {
                double r = double.Parse(Console.ReadLine());
                double area = r * r * Math.PI;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == triangle)
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double area = (a * ha) / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}