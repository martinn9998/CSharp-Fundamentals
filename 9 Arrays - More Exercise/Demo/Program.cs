int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] array2 = new int[0];
int[] arrayReconstructed = new int[0];
if (array.Length == 8)
{
    array2 = new int[8 / 2];
    arrayReconstructed = new int[8 / 2];
    int a = 0, r = 0;
    int x1 = 2;
    for (int i = 0; i < array.Length; i++)
    {

        if (i == 0)
        {
            array2[a] = array[1];
            a++;
            continue;
        }
        if (i == 1)
        {
            array2[a] = array[0];
            a++;
            continue;
        }
        if (x1 < 6)
        {
            arrayReconstructed[r] = array[i];
            r++;
            x1++;
            continue;
        }
        if (i == array.Length - 2)
        {
            array2[a] = array[array.Length - 1];
            a++;
            continue;
        }
        if (i == array.Length - 1)
        {
            array2[a] = array[array.Length - 2];
            continue;
        }

    }
}
else if (array.Length == 12)
{
    array2 = new int[12 / 2];
    arrayReconstructed = new int[12 / 2];
    int a = 0, r = 0;
    int x1 = 3;
    for (int i = 0; i < array.Length; i++)
    {

        if (i == 0)
        {
            array2[a] = array[2];
            a++;
            continue;
        }
        if (i == 1)
        {
            array2[a] = array[1];
            a++;
            continue;
        }
        if (i == 2)
        {
            array2[a] = array[0];
            a++;
            continue;
        }
        if ( x1 < 9)
        {
            arrayReconstructed[r] = array[i];
            r++;
            x1++;
            continue;
        }
        if (i == array.Length - 3)
        {
            array2[a] = array[array.Length - 1];
            a++;
            continue;
        }
        if (i == array.Length - 2)
        {
            array2[a] = array[array.Length - 2];
            a++;
            continue;
        }
        if (i == array.Length - 1)
        {
            array2[a] = array[array.Length - 3];
            continue;
        }

    }
}
if (array.Length == 4)
{
    array2 = new int[4 / 2];
    arrayReconstructed = new int[4 / 2];
    int a = 0, r = 0;
    int x1 = 1;
    for (int i = 0; i < array.Length; i++)
    {

        if (i == 0)
        {
            array2[a] = array[i];
            a++;
            continue;
        }
        if (x1 < 3)
        {
            arrayReconstructed[r] = array[i];
            r++;
            x1++;
            continue;
        }
        if (i == array.Length - 1)
        {
            array2[a] = array[i];
            continue;
        }

    }
}
int[] newArray = new int[array2.Length];
for (int i = 0; i < array2.Length; i++)
{
    newArray[i] = array2[i] + arrayReconstructed[i];
}

foreach (int i in newArray)
{
    Console.Write(i + " ");
}