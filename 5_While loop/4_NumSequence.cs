using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string input = Console.ReadLine();
                int max = int.MinValue;
                int min = int.MaxValue;
                while (true)
                {
                    if (input == "END")
                    {
                        Console.WriteLine("Max number: {0}", max);
                        Console.WriteLine("Min number: {0}", min);
                        break;
                    }
                    int num = int.Parse(input);
                    if (max < num)
                    {
                        max = num;
                    }
                    if (min > num)
                    {
                        min = num;
                    }
                    input = Console.ReadLine();
                }
            }
        }
    }
}