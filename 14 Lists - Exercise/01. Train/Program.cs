using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
         .Split()
         .Select(int.Parse)
         .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string operation;
            while ((operation= Console.ReadLine()) != "end")
            {
                string[] operationArr = operation                                .Split()
                                .ToArray();
                switch (operationArr[0])
                {
                    case "Add":
                        Adding(numbers, int.Parse(operationArr[1]));
                        break;
                    default:
                        Insert(numbers, int.Parse(operationArr[0]), maxCapacity);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void Adding(List<int> numbers, int number)
        {
            numbers.Add(number);
        }
        static void Insert(List<int> numbers, int number, int maxCapacity)
        {
           for (int d = 0;d < numbers.Count; d++)
            {
                if (numbers[d] + number <= maxCapacity)
                {
                    numbers[d] += number;
                    break;
                }
            }
        }
    }
}
