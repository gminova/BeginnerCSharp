using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int passangers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());
            for (int i = 1; i <= stops; i++)
            {
                if (i % 2 != 0)
                {
                    int remove = int.Parse(Console.ReadLine());
                    int add = int.Parse(Console.ReadLine());
                    add += 2;
                    passangers = passangers + add - remove;
                }
                else
                {
                    int remove = int.Parse(Console.ReadLine());
                    remove += 2;
                    int add = int.Parse(Console.ReadLine());
                    passangers = passangers + add - remove;
                }
            }
            Console.WriteLine($"The final number of passengers is : {passangers}");
        }
    }
}