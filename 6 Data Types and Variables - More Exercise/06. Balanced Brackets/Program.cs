int n = int.Parse(Console.ReadLine());
char ch = ' ';
bool start = false;
int starting = 0, ending = 0;
for (int i = 1; i <= n; i++)
{
    string str = Console.ReadLine();
    ch = str[0];

    if (ch == '(')
    {
        starting++;
    }

    if (ch == ')')
    {
        ending++;
    }



}
if (starting == ending)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}