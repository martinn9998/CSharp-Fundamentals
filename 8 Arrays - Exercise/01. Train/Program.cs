int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];
int sum = 0;
for (int i = 0; i < n; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());

}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();
for (int i = 0;i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);