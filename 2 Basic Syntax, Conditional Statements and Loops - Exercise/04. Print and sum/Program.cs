var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var sum = 0;
for (int i = a; i <= b; i++)
{
    Console.Write($"{i} ");
    sum += i;
}
Console.WriteLine();
Console.Write($"Sum: {sum}");