int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int n = int.Parse(Console.ReadLine());
int arrayRotationNumber = 0;
arrayRotationNumber = array[0];
for (int i = 1; i <= n; i++)
{
    arrayRotationNumber = array[0];
    for (int u = 0; u < array.Length; u++)
    {
        if (u == array.Length - 1)
        {
            array[u] = arrayRotationNumber;

        }
        else
        {
            array[u] = array[u + 1];
        }
    }
}

for (int l = 0; l < array.Length; l++)
{
    Console.Write(array[l] + " ");
}