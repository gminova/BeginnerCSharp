using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k <= i; k++)
            {
                if (counter > n)
                {
                    break;
                }
                Console.Write(counter + " ");
                counter++;
            }
            Console.WriteLine();
        }
    }
}