int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int n4 = int.Parse(Console.ReadLine());
int calculation = 0;
if (n1>int.MinValue && n1<int.MaxValue && n2>int.MinValue && n2<int.MaxValue)
{
    calculation = n1 + n2;
}
if (n3 > int.MinValue && n3 < int.MaxValue)
{
    calculation = calculation / n3;
}
if (n4 > int.MinValue && n4 < int.MaxValue)
{
    calculation *= n4;
}
Console.WriteLine(calculation);