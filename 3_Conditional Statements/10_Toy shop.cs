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
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddies = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int numOfToys = puzzles + dolls + teddies + minions + trucks;
            double puzzlesCost = puzzles * 2.60;
            double dollsCost = dolls * 3.0;
            double teddiesCost = teddies * 4.10;
            double minionsCost = minions * 8.20;
            double trucksCost = trucks * 2.0;
            double totalcost = puzzlesCost + dollsCost + teddiesCost + minionsCost + trucksCost;
            if (numOfToys >= 50)
            {
                double postDiscount = totalcost - 0.25 * totalcost;
                double afterRent = postDiscount - 0.1 * postDiscount;
                if (afterRent >= vacationPrice)
                {
                    double moneyLeft = afterRent - vacationPrice;
                    Console.WriteLine("Yes! {0} lv left.", ($"{moneyLeft:f2}"));
                }
                else if (afterRent < vacationPrice)
                {
                    double moneyNeeded = vacationPrice - afterRent;
                    Console.WriteLine("Not enough money! {0} lv needed.", ($"{moneyNeeded:f2}"));
                }
            }
            else
            {
                double afterRent = totalcost - 0.1 * totalcost;
                if (afterRent >= vacationPrice)
                {
                    double moneyLeft = afterRent - vacationPrice;
                    Console.WriteLine("Yes! {0} lv left.", ($"{moneyLeft:f2}"));
                }
                else if (afterRent < vacationPrice)
                {
                    double moneyNeeded = vacationPrice - afterRent;
                    Console.WriteLine("Not enough money! {0} lv needed.", ($"{moneyNeeded:f2}"));
                }
            }
        }
    }
}