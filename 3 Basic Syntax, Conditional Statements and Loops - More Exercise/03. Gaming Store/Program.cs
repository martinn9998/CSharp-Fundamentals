double budget = double.Parse(Console.ReadLine());
string input = Console.ReadLine();
double spent = 0;
while (input != "Game Time")
{
    if (budget==0)
    {
        break;
    }
    if (input == "OutFall 4")
    {
        budget -= 39.99;
        if (budget < 0)
        {
            Console.WriteLine("Too Expensive");
            budget += 39.99;
        }
        else
        {
            Console.WriteLine($"Bought {input}");
            spent += 39.99;
        }
    }
    else if (input == "CS: OG")
    {
        budget -= 15.99;
        if (budget < 0)
        {
            Console.WriteLine("Too Expensive");
            budget += 15.99;
        }
        else
        {
            Console.WriteLine($"Bought {input}");
            spent += 15.99;
        }
    }
    else if (input == "Zplinter Zell")
    {
        budget -= 19.99;
        if (budget < 0)
        {
            Console.WriteLine("Too Expensive");
            budget += 19.99;
        }
        else
        {
            Console.WriteLine($"Bought {input}");
            spent += 19.99;
        }
    }
    else if (input == "Honored 2")
    {
        budget -= 59.99;
        if (budget < 0)
        {
            Console.WriteLine("Too Expensive");
            budget += 59.99;
        }
                else
        {
            Console.WriteLine($"Bought {input}");
            spent += 59.99;
        }
    }
    else if (input == "RoverWatch")
    {
        budget -= 29.99;
        if (budget < 0)
        {
            Console.WriteLine("Too Expensive");
            budget += 29.99;
        }
                else
        {
            Console.WriteLine($"Bought {input}");
            spent += 29.99;
        }
    }
    else if (input == "RoverWatch Origins Edition")
    {
        budget -= 39.99;
        if (budget < 0)
        {
            Console.WriteLine("Too Expensive");
            budget += 39.99;
        }
        else
        {
            Console.WriteLine($"Bought {input}");
            spent += 39.99;
        }
    }
    else
    {
        Console.WriteLine("Not Found");
    }
    input = Console.ReadLine();
}
if (budget<=0)
{
    Console.WriteLine("Out of money!");
}
else
{
    Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${budget:f2}");
}