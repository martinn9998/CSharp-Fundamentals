int n = int.Parse(Console.ReadLine());
double maxValue = int.MinValue, maxQuantuty = 0, maxSnowbaballSnow = 0,
    maxSnowballTime = 0;
for (int i = 1; i <= n; i++)
{
    double snowbaballSnow = double.Parse(Console.ReadLine());
    double snowballTime = double.Parse(Console.ReadLine());
    double snowballQuantity = double.Parse(Console.ReadLine());
    double snowballValue = Math.Pow((snowbaballSnow / snowballTime), snowballQuantity);
    if (snowballValue > maxValue)
    {
        maxValue = snowballValue;
        maxQuantuty = snowballQuantity;
        maxSnowbaballSnow = snowbaballSnow;
        maxSnowballTime = snowballTime;
    }
}
Console.WriteLine($"{maxSnowbaballSnow} : {maxSnowballTime} = {maxValue} ({maxQuantuty})");