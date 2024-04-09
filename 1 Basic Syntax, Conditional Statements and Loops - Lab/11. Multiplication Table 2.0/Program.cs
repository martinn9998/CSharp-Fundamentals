var n = int.Parse(Console.ReadLine());
var p = int.Parse(Console.ReadLine());
for (int i = p; i <= 10; i++)
{
    Console.WriteLine($"{n} X {i} = {n * i}");
}
if (p>10)
{
    Console.WriteLine($"{n} X {p} = {n * p}");
}