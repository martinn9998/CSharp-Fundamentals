using System.Runtime.CompilerServices;

string s = Console.ReadLine();
char letter = ' ';
for (int i = 0; i < s.Length; i++)
{
    letter = s[i];
    if (i < s.Length-1)
    {}
    else
    {
        if (letter == '1') 
        {
            Console.WriteLine("one");
        }
        else if (letter == '2')
        {
            Console.WriteLine("two");
        }
        else if (letter == '3')
        {
            Console.WriteLine("three");
        }
        else if (letter == '4')
        {
            Console.WriteLine("four");
        }
        else if (letter == '5')
        {
            Console.WriteLine("five");
        }
        else if (letter == '6')
        {
            Console.WriteLine("six");
        }
        else if (letter == '7')
        {
            Console.WriteLine("seventh");
        }
        else if (letter == '8')
        {
            Console.WriteLine("eight");
        }
        else if (letter == '9')
        {
            Console.WriteLine("nine");
        }

    }
}

