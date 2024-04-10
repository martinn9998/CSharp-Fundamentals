using System.Runtime.CompilerServices;

int n = int.Parse(Console.ReadLine());
decimal input = 0;
decimal sum = 0;
for  (int i = 1; i <= n; i++)
{
    input = decimal.Parse(Console.ReadLine());
    sum += input;
}
Console.WriteLine($"{sum}");