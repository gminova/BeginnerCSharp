using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int change = (int)(double.Parse(Console.ReadLine()) * 100);

            int twoLeva = 200;
            int oneLeva = 100;
            int fiftyStotinki = 50;
            int twentyStotinki = 20;
            int tenStotinki = 10;
            int fiveStotinki = 5;
            int twoStotinki = 2;
            int oneStotinka = 1;

            int twoLevaNum = change / twoLeva;
            change %= twoLeva;
            int oneLevaNum = change / oneLeva;
            change %= oneLeva;
            int fiftyStotinkiNum = change / fiftyStotinki;
            change %= fiftyStotinki;
            int twentyStotinkiNum = change / twentyStotinki;
            change %= twentyStotinki;
            int tenStotinkiNum = change / tenStotinki;
            change %= tenStotinki;
            int fiveStotinkiNum = change / fiveStotinki;
            change %= fiveStotinki;
            int twoStotinkiNum = change / twoStotinki;
            change %= twoStotinki;
            int oneStotinkaNum = change / oneStotinka;

            int numCoins = twoLevaNum + oneLevaNum + fiftyStotinkiNum +
                twentyStotinkiNum + tenStotinkiNum + fiveStotinkiNum + twoStotinkiNum + oneStotinkaNum;
            Console.WriteLine(numCoins);
        }
    }
}