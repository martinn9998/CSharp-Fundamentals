int howMuch = int.Parse(Console.ReadLine());
for (int i = 1; i <= h; i++)
{
    int number = i;
    int sum = 0;
    while (i > 0)
    {
        sum += i % 10;
        i = i / 10;
    }
    bool itIs = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", number, itIs);
    sum = 0;
    i = number;
}
