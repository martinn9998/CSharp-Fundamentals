int n = int.Parse(Console.ReadLine());
string[] stringArray = new string[n];
int s = 0;
string output = "";
for (int i = 0; i < n; i++)
{
    stringArray[s] = Console.ReadLine();
    s++;
}
s--;
for  (int i = n; i > 0; i--)
{
    output += stringArray[s] + " ";
    s--;
}
Console.WriteLine(output);