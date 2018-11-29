using System;

class Program
{
    static void Main(string[] args)
    {
        int floors = int.Parse(Console.ReadLine());
        int rooms = int.Parse(Console.ReadLine());

        for (int row = floors; row > 0; row--)
        {
            for (int column = 0; column < rooms; column++)
            {
                if (row == floors)
                {
                    Console.Write($"L{row}{column} ");
                }
                else if (row % 2 == 0)
                {
                    Console.Write($"O{row}{column} ");
                }
                else
                {
                    Console.Write($"A{row}{column} ");
                }
            }
            Console.WriteLine();
        }
    }
}