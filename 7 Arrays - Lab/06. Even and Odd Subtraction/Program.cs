int[] number = Console.ReadLine().Split()
    .Select(int.Parse).ToArray();
int evenSum = 0, oddSum = 0;
for (int  i = 0;i < number.Length;i ++)
{
    int currrentNumber = number[i];
    if (currrentNumber % 2 == 0 )
    {
        evenSum += currrentNumber;
    }
    else
    {
        oddSum += currrentNumber;
    }
}
int difference = evenSum - oddSum;
Console.WriteLine(difference);