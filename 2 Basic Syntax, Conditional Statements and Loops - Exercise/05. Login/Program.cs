using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public static class Test
{
    private static IEnumerable<string> GraphemeClusters(this string s)
    {
        var enumerator = StringInfo.GetTextElementEnumerator(s);
        while (enumerator.MoveNext())
        {
            yield return (string)enumerator.Current;
        }
    }
    private static string ReverseGraphemeClusters(this string s)
    {
        return string.Join("", s.GraphemeClusters().Reverse().ToArray());
    }

    public static void Main()
    {
        var s = Console.ReadLine();
        var r = s.ReverseGraphemeClusters();
        var password = Console.ReadLine();
        bool correct = false;
        bool blocked = false;
        for (int i = 1; i <= 4; i++)
        {
            if (i >= 1 && i <= 3)
            {

                if (password == r)
                {
                    correct = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    password = Console.ReadLine();
                }
            }
            if (i == 4)
            {
                if (password == r)
                {
                    correct = true;
                    break;
                }
                else
                {
                    blocked = true;
                    break;
                }

            }

        }
        if (correct)
        {
            Console.WriteLine($"User {s} logged in.");
        }
        if (blocked)
        {
            Console.WriteLine($"User {s} blocked!");
        }

    }
}