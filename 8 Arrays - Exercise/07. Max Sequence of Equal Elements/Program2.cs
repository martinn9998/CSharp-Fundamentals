namespace MaxSequenceOfEqualElements
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int count = 1, maxCount = 0, element = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    element = numbers[i];
                }
            }
            for (int i = 1;i <= maxCount;i++)
            {
                Console.Write(element + " ");
            }
        }
    }
}