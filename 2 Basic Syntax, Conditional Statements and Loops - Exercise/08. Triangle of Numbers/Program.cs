int n = int.Parse(Console.ReadLine());
int current = 1;
int cols = 1;
for (int rows = 1; rows <= n; rows++)
{
    for (; cols <= rows; cols++)
    {

        Console.Write($"{rows} ");
        current++;

    }
    Console.WriteLine();
    cols = 1;
}