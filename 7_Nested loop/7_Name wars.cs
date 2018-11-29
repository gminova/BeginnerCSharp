using System;
using System.Text;

class nameWars
{
    public static void Main()
    {
        ASCIIEncoding ascii = new ASCIIEncoding();
        int maxSum = int.MinValue;
        string name = string.Empty;
        string winner = string.Empty;
        while (true)
        {
            int currentSum = 0;
            name = Console.ReadLine();
            if (name == "STOP") break;
            byte[] encodedBytes = ascii.GetBytes(name);
            foreach (byte b in encodedBytes)
            {
                currentSum += b;
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    winner = ascii.GetMaxCharCount(encodedBytes);
                }
            }
        }
        Console.WriteLine($"Winner is {winner} - {maxSum}!");
    }
}