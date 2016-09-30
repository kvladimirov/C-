using System;


namespace PassionDays
{
    class PassionDays
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());          
            string input = Console.ReadLine();
            int purchases = 0;
            
            while (input != "mall.Enter")
            {
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "mall.Exit")
            {
                string data = input;     
                for (int i = 0; i < data.Length; i++)
                {
                    decimal price = 0;
                    if (data[i] >= 65 && data[i] <= 90)
                    {
                        price = data[i] * 0.5m;
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                        
                    }
                    else if (data[i] >= 97 && data[i] <= 122)
                    {
                        price = data[i] * 0.3m;
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                        
                    }
                    else if (data[i] == '%')
                    {
                        if (money > 0)
                        {
                            money /= 2;
                            purchases++;
                        }
                    }
                    else if (data[i] == '*')
                    {
                        money += 10;
                    }
                    else
                    {
                        price = data[i];
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;                
                    }
                }
                
                input = Console.ReadLine();       
            }
            
            if (purchases == 0)
            {
                Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{purchases} purchases. Money left: {money:f2} lv.");
            }
        }
    }
}
