
int n = int.Parse(Console.ReadLine());
int quantity = 0;
int max = 0; 
for (int i = 1; i <= n; i++)
{

    quantity = int.Parse(Console.ReadLine());
    max += quantity;
    if (max > 255)
    {
        Console.WriteLine("Insufficient capacity!");
        max -= quantity;
        continue;
    }

}

Console.WriteLine(max);