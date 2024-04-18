using System;

namespace PascalTriangle
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var s = new int[n][];

            for (int i = 0; i < n; i++)
            {
                s[i] = new int[i + 1];
                s[i][0] = 1;  // first element is 1
                s[i][^1] = 1; // last element is 1

                for (int d = 1; d < i; d++)
                {
                    Console.WriteLine(s[i][d]);
                    s[i][d] = s[i - 1][d - 1] + s[i - 1][d];
                    Console.WriteLine(s[i][d]);
                }
                Console.WriteLine(string.Join(" ", s[i]));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", s[i]));
            }
        }
    }
}