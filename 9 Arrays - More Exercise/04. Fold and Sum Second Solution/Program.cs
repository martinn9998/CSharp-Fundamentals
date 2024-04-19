using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] leftArray = new int[array.Length / 4];
            Console.WriteLine(string.Join(" ",leftArray));    //Remove
            int[] rightArray = new int[array.Length / 4];
            Console.WriteLine(string.Join(" ", rightArray));  //Remove

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = array[array.Length / 4 - i - 1];
                Console.WriteLine(string.Join(" ", leftArray));  //Remove
                rightArray[i] = array[array.Length - i - 1];
                Console.WriteLine(string.Join(" ", rightArray));  //Remove
            }

            int[] sumArray = new int[array.Length / 2];

            for (int i = 0; i < leftArray.Length; i++)
            {
                sumArray[i] = leftArray[i] + array[array.Length / 4 + i];
                Console.WriteLine(string.Join(" ", sumArray));  //Remove
                sumArray[array.Length / 4 + i] = rightArray[i] +
                    array[array.Length / 2 + i];
                Console.WriteLine(string.Join(" ", sumArray));  //Remove
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}