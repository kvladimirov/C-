using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUniAirline
{
    class SoftUniAirline
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            decimal income = 0;
            decimal expense = 0;
            decimal fullIncome = 0;
            decimal fullExpense = 0;

            for (int i = 0; i < n; i++)
            {
                int adultPassengersCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine()); 
                int youthPassengersCount = int.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                decimal fuelConsumption = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());
                income = (adultPassengersCount * adultTicketPrice) + (youthPassengersCount * youthTicketPrice);
                fullIncome += income;
                expense = (flightDuration * (fuelConsumption * fuelPrice));
                fullExpense += expense;
                if (income >= expense)
                {
                    Console.WriteLine($"You are ahead with {income - expense:f3}$.");
                   
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {income - expense:f3}$.");
                    
                }
              
            }
            Console.WriteLine($"Overall profit -> {fullIncome - fullExpense:f3}$.");
            Console.WriteLine($"Average profit -> {(fullIncome - fullExpense) / n:f3}$.");
        }
    }
}
