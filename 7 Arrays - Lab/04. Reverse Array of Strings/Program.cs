string[] words = Console.ReadLine().Split(' ');
string[] reverse = new string[words.Length];
int r = 0;
for (int i = words.Length - 1; i >= 0; i--, r++)
{
    reverse[r] = (string)words[i];
    Console.Write(reverse[r] + " ");
}