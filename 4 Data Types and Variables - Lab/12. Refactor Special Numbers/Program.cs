int howMuch = int.Parse(Console.ReadLine());

for (int i = 1; i <= howMuch; i++)
{
    int sum = 0;
    bool trueOrFalse = false;
    int current = i;
    while (i > 0)
    {
        sum += i % 10;
        i = i / 10;
    }
    trueOrFalse = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", current, trueOrFalse);
    sum = 0;
    i = current;
}

