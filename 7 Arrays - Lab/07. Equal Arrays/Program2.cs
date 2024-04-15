using System;

namespace EqualArrays
{
    class Program
    {
        public static void Main()
        {
            int[] arrNumbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] arrNumbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var sum = 0;
            bool flag = true;
            for (int i = 0; i < arrNumbers1.Length; i++)
            {
                if (arrNumbers1[i] == arrNumbers2[i])
                {
                    sum += arrNumbers1[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}