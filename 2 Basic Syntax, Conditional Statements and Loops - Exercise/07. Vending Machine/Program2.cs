namespace VendingMachine
{
    class Programm
    {
        public static void Main()
        {
            double money = 0;
            money = MoneySum(money);
            money = MoneySpend(money);
            Console.WriteLine($"Change: {money:f2}");
        }
        static double MoneySum(double money)
        {
            string input;
            while ((input = Console.ReadLine()) != "Start")
            {
                var coin = double.Parse(input);
                if (coin == 2)
                {
                    money += 2;
                }
                else if (coin == 1)
                {
                    money += 1;
                }
                else if (coin == 0.5)
                {
                    money += 0.5;
                }
                else if (coin == 0.2)
                {
                    money += 0.2;
                }
                else if (coin == 0.1)
                {
                    money += 0.1;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }
            return money;
        }
        static double MoneySpend(double money)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Nuts")
                {
                    if (money >= 2)
                    {
                        Console.WriteLine("Purchased nuts");
                        money -= 2;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Water")
                {
                    if (money >= 0.7)
                    {
                        Console.WriteLine("Purchased water");
                        money -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Crisps")
                {
                    if (money >= 1.5)
                    {
                        Console.WriteLine("Purchased crisps");
                        money -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Soda")
                {
                    if (money >= 0.8)
                    {
                        Console.WriteLine("Purchased soda");
                        money -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    if (money >= 1)
                    {
                        Console.WriteLine("Purchased coke");
                        money -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            return money;
        }
    }
}