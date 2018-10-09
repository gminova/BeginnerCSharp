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
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0.0;
            switch (operation)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/": result = num1 / num2; break;
                case "%": result = num1 % num2; break;
            }
            if (result % 2 == 0 && (operation == "+" || operation == "-" || operation == "*"))
            {
                Console.WriteLine("{0} {1} {2} = {3} - even", num1, operation, num2, result);
            }
            else if (result % 2 != 0 && (operation == "+" || operation == "-" || operation == "*"))
            {
                Console.WriteLine("{0} {1} {2} = {3} - odd", num1, operation, num2, result);
            }
            else if (operation == "/" && num2 != 0)
            {
                Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, $"{result:f2}");
            }
            else if (operation == "%" && num2 != 0)
            {
                Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, result);
            }
            else
            {
                Console.WriteLine("Cannot divide {0} by zero", num1);
            }
        }
    }
}