namespace GamingStore
{
    class Programm
    {
        public static void Main()
        {
            var fallout4Price = 39.99;
            var csOG = 15.99;
            var zplinterZell = 19.99;
            var honored2 = 59.99;
            var roverWatch = 29.99;
            var roverWatchOriginsEdition = 39.99;
            double currentBalance = double.Parse(Console.ReadLine());
            string input;
            bool bought = false;
            var totalSpendCounter = 0.0;
            while((input = Console.ReadLine()) != "Game Time")
            {
                if (input== "OutFall 4")
                {
                    if (currentBalance >= fallout4Price)
                    {
                        bought = true;
                        currentBalance -= fallout4Price;
                        totalSpendCounter += fallout4Price;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input== "CS: OG")
                {
                    if (currentBalance >= csOG)
                    {
                        bought = true;
                        currentBalance -= csOG;
                        totalSpendCounter += csOG;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input== "Zplinter Zell")
                {
                    if (currentBalance >= zplinterZell)
                    {
                        bought = true;
                        currentBalance -= zplinterZell;
                        totalSpendCounter += zplinterZell;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Honored 2")
                {
                    if (currentBalance >= honored2)
                    {
                        bought = true;
                        currentBalance -= honored2;
                        totalSpendCounter += honored2;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch")
                {
                    if (currentBalance >= roverWatch)
                    {
                        bought = true;
                        currentBalance -= roverWatch;
                        totalSpendCounter += roverWatch;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (currentBalance >= roverWatchOriginsEdition)
                    {
                        bought = true;
                        currentBalance -= roverWatchOriginsEdition;
                        totalSpendCounter += roverWatchOriginsEdition;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (bought)
                {
                    Console.WriteLine($"Bought {input}");
                    bought = false;
                }
                if (currentBalance<=0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            if (input== "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpendCounter:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}