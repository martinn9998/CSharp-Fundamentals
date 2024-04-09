using System.Runtime.InteropServices;

string input = Console.ReadLine();
double sum = 0, coin = 0;
bool noMoney = false;
while (input!= "Start")
{
    coin = double.Parse(input);
    if (coin == 2 || coin == 1 || coin == 0.5 || coin == 0.2 || coin == 0.1)
    {
        
        sum += coin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }
    input = Console.ReadLine();
}

while (true)
{
    input = Console.ReadLine();
    if (input == "End")
    {
        break;
    }
    if (input == "Coke")
    {
        sum -= 1;
        if (sum < 0)
        {
            sum += 1;
            noMoney = true;
        }

    }
    else if (input == "Soda")
    {
        sum -= 0.8;
        if (sum < 0)
        {
            sum += 0.8;
            noMoney = true;
        }
     
    }
    else if (input == "Crisps")
    {
        sum -= 1.5;
        if (sum < 0)
        {
            sum += 1.5;
            noMoney = true;
        }

    }
    else if (input == "Water")
    {
        sum -= 0.7;
        if (sum < 0)
        {
            sum += 0.7;
            noMoney = true;
        }
      
    }
    else if (input == "Nuts")
    {
        sum -= 2.0;
        if (sum < 0)
        {
            sum += 2;
            noMoney = true;
        }

    }
    else
    {
        Console.WriteLine("Invalid product");
        continue;
    }

    if (noMoney)
    {
        
        Console.WriteLine("Sorry, not enough money");
        noMoney= false;
    }
    else
    {

        Console.WriteLine($"Purchased {input.ToLower()}");
        continue;
    }

    
}
Console.WriteLine($"Change: {sum:f2}");