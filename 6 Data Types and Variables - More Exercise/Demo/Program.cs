
bool isTrue = false;
bool isTrue2 = false;
int primeNumbersSum = 0;
int nonpPrimeNumbersSum = 0;
int d = 1;
for (int i = 0; i < d; i++)
{
    if (isTrue)
    {
        break;
    }
    string textn1 = Console.ReadLine();
    if (textn1 == "stop")
    {
        isTrue = true;
        Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonpPrimeNumbersSum}");
        break;
    }
    int n1 = int.Parse(textn1);
    if (n1 < 0)
    {
        d++;
        Console.WriteLine("Number is negative.");
        continue;
    }
    int s, m = 0, flag = 0;

    m = x1 / 2;
    for (s = 2; s <= m; s++)
    {
        if (x1 % s == 0)
        {
            flag = 1;
            nonpPrimeNumbersSum += x1;
            d++;
            break;
        }
    }
    if (flag == 0)
        primeNumbersSum += x1;
    d++;
}