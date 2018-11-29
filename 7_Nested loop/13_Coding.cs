using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = n.ToString().Length;

            for (int i = num; i > 0; i--)
            {

                do
                {
                    int digit = n % 10;
                    if (digit == 0)
                    {
                        Console.WriteLine("ZERO");
                    }
                    else
                    {
                        char symbol = Convert.ToChar(digit + 33);
                        Console.WriteLine(new string(symbol, digit));
                    }
                    n /= 10;
                } while (i == 0);

            }

        }
    }
}