namespace CondenseArrayToNumber
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                int[] condense = new int[numbers.Length - 1];
                for (int l = 0; l < numbers.Length; l++)
                {
                    for (int x = 0; x < condense.Length - l; x++)
                    {
                        condense[x] = numbers[x] + numbers[x + 1];
                    }
                    condense =numbers;
                }
                Console.WriteLine(numbers[0]);
            }
        }
    }
}