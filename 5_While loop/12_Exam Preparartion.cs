using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failMax = int.Parse(Console.ReadLine());
            string problem = string.Empty;
            string lastProblem = string.Empty;
            int failCount = 0;
            double marksTotal = 0;
            int totalMarksCounter = 0;
            while (failCount < failMax)
            {
                problem = Console.ReadLine();
                if (problem == "Enough")
                {
                    break;
                }
                else
                {
                    lastProblem = problem;
                }
                double mark = double.Parse(Console.ReadLine());
                if (mark <= 4.0)
                {
                    failCount += 1;
                }
                marksTotal += mark;
                totalMarksCounter += 1;
            }
            if (failCount == failMax)
            {
                Console.WriteLine($"You need a break, {failCount} poor grades.");
            }
            else if (failCount < failMax)
            {
                Console.WriteLine($"Average score: {(marksTotal / totalMarksCounter):f2}");
                Console.WriteLine($"Number of problems: {totalMarksCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}