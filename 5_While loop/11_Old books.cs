using System;

namespace oldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string foundTitle = Console.ReadLine();
            int booksMax = int.Parse(Console.ReadLine());
            string searchedTitle = string.Empty;
            int counter = 0;
            while (counter < booksMax)
            {
                searchedTitle = Console.ReadLine();
                counter++;
                if (searchedTitle == foundTitle)
                {
                    Console.WriteLine($"You checked {counter - 1} books and found it.");
                    break;
                }
            }
            if (searchedTitle != foundTitle)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}