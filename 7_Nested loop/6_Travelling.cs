using System;

namespace travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End") break;
                double cost = double.Parse(Console.ReadLine());
                while (cost > 0)
                {
                    cost -= double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}