int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int isBigger = 0;
for (int x1 = 0; x1 < array.Length; x1++)
{
    for (int x2 = x1; x2 < array.Length; x2++)
    {
        if (array[x1] > array[x2])
        {
            isBigger++;
        }
    }
    if (isBigger == array.Length - (x1 + 1))
    {
        Console.Write(array[x1] + " ");
    }
    isBigger = 0;
}