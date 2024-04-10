int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int maxNumer = int.MinValue;
int middleNumber = 0;
int minNumber = int.MaxValue;
int countA = 0, countB = 0, countC = 0;

for (int i = 1; i <= 3; i++)
{
    if (countA == 0 && a > maxNumer)
    {
        countA++;
        maxNumer = a;
    }
    else if (countB == 0 && b > maxNumer)
    {
        countB++;
        maxNumer = b;
    }
    else if (countC == 0 && c > maxNumer)
    {
        countC++;
        maxNumer = c;
    }
}
countA = 0; countB = 0; countC = 0;

for (int i = 1; i <= 3; i++)
{
    if (countA == 0 && a < minNumber)
    {
        countA++;
        minNumber = a;
    }
    else if (countB == 0 && b < minNumber)
    {
        countB++;
        minNumber = b;
    }
    else if (countC == 0 && c < minNumber)
    {
        countC++;
        minNumber = c;
    }
}

if (a < maxNumer && a > minNumber)
{
    middleNumber = a;
}
else if (b < maxNumer && b > minNumber)
{
    middleNumber = b;
}
else if (c < maxNumer && c > minNumber)
{
    middleNumber = c;
}
else if (a == minNumber)
{
    middleNumber = a;
}
else if (b == minNumber)
{
    middleNumber = b;
}
else if (c == minNumber)
{
    middleNumber = c;
}
Console.WriteLine(maxNumer);
Console.WriteLine(middleNumber);
Console.WriteLine(minNumber);