int key = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
string word = "";
for (int i = 1; i <= n; i++)
{
    char input = char.Parse(Console.ReadLine());
    int number = input;
    number += key;
    input = (char)number;
    word += input;
}
Console.WriteLine(word);