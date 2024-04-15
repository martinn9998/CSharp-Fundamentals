int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
bool exist = false;
int element = 0, i = 0;
for (; i < array.Length; i++)
{
    element = array[i];
    int sumLeft = 0;
    int sumRight = 0;
    for (int x1 = 0; x1 < i; x1++)
    {
        sumLeft += array[x1];
    }
    for (int x2 = i + 1; x2 < array.Length; x2++)
    {
        sumRight += array[x2];
    }
    if (sumLeft == sumRight)
    {
        exist = true;
        break;
    }
}
if (exist)
{
    Console.WriteLine(i);
}
else
{
    Console.WriteLine("no");
}