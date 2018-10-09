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
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberPeople = int.Parse(Console.ReadLine());
            double transportCost = 0.00;
            if (category == "Normal")
            {
                double ticketCost = 249.99;
                budget = budget - transportCost;
                if (numberPeople >= 1 && numberPeople <= 4)
                {
                    transportCost = budget * 0.75;
                    budget = budget - transportCost;
                }
                else if (numberPeople >= 5 && numberPeople <= 9)
                {
                    transportCost = budget * 0.60;
                    budget = budget - transportCost;
                }
                else if (numberPeople >= 10 && numberPeople <= 24)
                {
                    transportCost = budget * 0.50;
                    budget = budget - transportCost;
                }
                else if (numberPeople >= 25 && numberPeople <= 49)
                {
                    transportCost = budget * 0.40;
                    budget = budget - transportCost;
                }
                else if (numberPeople >= 50)
                {
                    transportCost = budget * 0.25;
                    budget = budget - transportCost;
                }
                if ((numberPeople * ticketCost) < budget)
                {
                    Console.WriteLine($"Yes! You have {(budget - (numberPeople * ticketCost)):F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {((numberPeople * ticketCost) - budget):F2} leva.");
                }
            }
            else if (category == "VIP")
            {
                double ticketCost = 499.99;
                if (numberPeople >= 1 && numberPeople <= 4)
                {
                    transportCost = budget * 0.75;
                    budget = budget - transportCost;
                }
                else if (numberPeople >= 5 && numberPeople <= 9)
                {
                    transportCost = budget * 0.60;
                    budget = budget - transportCost;
                }
                else if (numberPeople >= 10 && numberPeople <= 24)
                {
                    transportCost = budget * 0.50;
                    budget = budget - transportCost;
                }
                else if (numberPeople >= 25 && numberPeople <= 49)
                {
                    transportCost = budget * 0.40;
                    budget = budget - transportCost;
                }
                else if (numberPeople >= 50)
                {
                    transportCost = budget * 0.25;
                    budget = budget - transportCost;
                }
                if ((numberPeople * ticketCost) < budget)
                {
                    Console.WriteLine($"Yes! You have {(budget - (numberPeople * ticketCost)):F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {((numberPeople * ticketCost) - budget):F2} leva.");
                }
            }
        }
    }
}