namespace EqualSum
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
            int leftSumOfTheNumbers = 0;
            int rightSumOfTheNumbers = numbers.Sum();
            for (int i = 0; i < numbers.Length; i++)
            {
                rightSumOfTheNumbers -= numbers[i];
                if (rightSumOfTheNumbers == leftSumOfTheNumbers)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSumOfTheNumbers += numbers[i];
            }
            Console.WriteLine("no");
        }
    }
}