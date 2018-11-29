using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentClass = 1;
            double totalGrades = 0;
            int exclude = 0;

            while (currentClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    ++exclude;
                    if (exclude > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {currentClass} grade");
                        break;
                    }
                }
                else if (grade >= 4.00)
                {
                    totalGrades += grade;
                    currentClass++;
                }
            }
            double averageGrade = totalGrades / 12.0;
            if (exclude == 0)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}