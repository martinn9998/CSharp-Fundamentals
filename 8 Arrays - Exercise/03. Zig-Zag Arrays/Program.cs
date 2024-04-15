int n = int.Parse(Console.ReadLine());
int[] arr1 = new int[n];
int[] arr2 = new int[n];
int o = 0, a = 0;
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 1)
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        if (o < n)
        {
            arr1[o] = array[a];
            arr2[o] = array[a + 1];
            o++;
        }
    }
    else
    {
        int[] array = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToArray();
        if (o < n)
        {
            arr2[o] = array[a];
            arr1[o] = array[a + 1];
            o++;
        }

    }
}
for (int i = 0; i < n; i++)
{
    Console.Write(arr1[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    Console.Write(arr2[i] + " ");
}