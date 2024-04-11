int n = int.Parse(Console.ReadLine());
char letter = ' ';
int sum = 0;
for (int i = 0; i < n; i++)
{
    letter = char.Parse(Console.ReadLine());
    if (letter>='a' && letter<='z' || letter >= 'A' && letter <= 'Z')
    {
        int char2Int = letter;
        sum += char2Int;
    }
}
Console.WriteLine($"The sum equals: {sum}");