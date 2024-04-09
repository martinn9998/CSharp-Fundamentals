int n = int.Parse(Console.ReadLine());
double sum = 0;
for (int i = 1; i <= n; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    double days = double.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());
    double formula = ((days * capsulesCount) * pricePerCapsule);
    Console.WriteLine($"The price for the coffee is: ${formula:f2}");
    sum += formula;
}
Console.WriteLine($"Total: ${sum:f2}");