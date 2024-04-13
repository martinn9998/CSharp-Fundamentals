int n = int.Parse(Console.ReadLine());
for (int x1 = 2; x1 <= n; x1++)
{

    int s, m = 0, flag = 0;
    m = x1 / 2;
    for (s = 2; s <= m; s++)
    {
        if (x1 % s == 0)
        {
            flag = 1;
            Console.WriteLine($"{x1} -> false");
            break;
        }
    }
    if (flag == 0)
    {
        Console.WriteLine($"{x1} -> true");
    }
}



