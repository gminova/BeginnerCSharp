using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        for (int num = num1; num <= num2; num++)
        {
            string numString = Convert.ToString(num);
            int sum1 = (numString[0] - '0') + (numString[1] - '0');
            int sum2 = (numString[3] - '0') + (numString[4] - '0');
            int midDigit = (numString[2] - '0');

            if (sum1 == sum2 || Math.Abs(sum1 - sum2) == midDigit)
            {
                Console.Write($"{num} ");
            }
        }
    }
}