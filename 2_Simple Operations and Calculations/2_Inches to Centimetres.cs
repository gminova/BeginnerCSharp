﻿using System;
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
            Console.Write("Inches = ");
            var Inches = double.Parse(Console.ReadLine());
            var Centimeters = Inches * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(Centimeters);
        }
    }
}