int n = int.Parse(Console.ReadLine());
n += 96;
char begin = 'a';
char end = (char)n;


for (char i = begin; i <= end; i++)
{

    for (char j = begin; j <= end; j++)
    {

        for (char k = begin; k <= end; k++)
        {

            Console.WriteLine($"{i}{j}{k} ");
        }
    }
}
