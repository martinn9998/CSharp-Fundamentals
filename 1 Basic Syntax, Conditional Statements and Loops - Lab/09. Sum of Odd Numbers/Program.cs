var n = int.Parse(Console.ReadLine());
var k = 1;
var sum = 0;
for (var i = 1; i <= n; i++)
{
    Console.WriteLine(k);
    sum += k;
    k += 2;
}
Console.WriteLine($"Sum: {sum}");