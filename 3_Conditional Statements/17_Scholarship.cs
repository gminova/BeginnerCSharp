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
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minIncome = double.Parse(Console.ReadLine());
            double SocialScholarship = 0.35 * minIncome;
            double ExcellentScholarship = grade * 25;
            if (income >= minIncome)
            {
                if (grade < 5.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(ExcellentScholarship));
                }
            }
            else
            {
                if (grade < 4.5)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (grade > 4.50 && grade < 5.50)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(SocialScholarship));
                }
                else if (grade > 5.50 && SocialScholarship > ExcellentScholarship)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(SocialScholarship));
                }
                else if (grade > 5.50 && SocialScholarship <= ExcellentScholarship)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(ExcellentScholarship));
                }
            }
        }
    }
}