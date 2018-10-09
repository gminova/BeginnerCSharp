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
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            int examTimeMin = hourExam * 60 + minExam;
            int arrivalTimeMin = arrivalHour * 60 + arrivalMin;
            int minDifference = Math.Abs(examTimeMin - arrivalTimeMin);
            int hours = minDifference / 60;
            int minutes = minDifference % 60;
            if (examTimeMin < arrivalTimeMin)
            {
                if (minDifference <= 59)
                {
                    Console.WriteLine("Late {0} minutes after the start", minDifference);
                }
                else if (minDifference >= 60)
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine("Late {0} : 0{1} hours after the start", hours, minutes);
                    }
                    else
                    {
                        Console.WriteLine("Late {0} : {1} hours after the start", hours, minutes);
                    }
                }
            }
            else if (examTimeMin == arrivalTimeMin)
            {
                Console.WriteLine("On time");
            }
            else if (examTimeMin > arrivalTimeMin)
            {
                if (minDifference <= 30)
                {
                    Console.WriteLine("On time {0} minutes before the start", minDifference);
                }
                else if (minDifference > 30 && minDifference <= 59)
                {
                    Console.WriteLine("Early {0} minutes before the start", minDifference);

                }
                else if (minDifference >= 60)
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine("Early {0} : 0{1} hours before the start", hours, minutes);
                    }
                    else
                    {
                        Console.WriteLine("Early {0} : {1} hours before the start", hours, minutes);
                    }
                }
            }
        }
    }
}