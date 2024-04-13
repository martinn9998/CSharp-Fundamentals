using System;

class EqualArrays
{
    static void Main(string[] args)
    {
        int[] arr1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int[] arr2 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        bool notIdentical = true;
        int sum = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                notIdentical = false;
                break;
            }
            else
            {
                sum += arr1[i];
            }
        }
        if (notIdentical)
        {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}