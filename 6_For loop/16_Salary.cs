using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            string website = string.Empty;
            double fine = 0;
            for (int i = 0; i < n; i++)
            {
                website = Console.ReadLine();
                switch (website)
                {
                    case "Facebook": fine = 150; salary -= fine; break;
                    case "Instagram": fine = 100; salary -= fine; break;
                    case "Reddit": fine = 50; salary -= fine; break;
                }
                if (salary <= 0) break;
            }
            if (0 >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}