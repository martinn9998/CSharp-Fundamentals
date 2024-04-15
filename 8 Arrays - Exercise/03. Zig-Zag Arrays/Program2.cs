namespace ZigZagArrays
{
    class Program
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            int[] firstArr = new int[linesCount];
            int[] secondArr = new int[linesCount];
            for (int i = 0; i < linesCount; i++)
            {
                int[] arrInput = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    firstArr[i] = arrInput[0];
                    secondArr[i] = arrInput[1];
                }
                else
                {
                    firstArr[i] = arrInput[1];
                    secondArr[i] = arrInput[0];
                }
            }
                Console.WriteLine(string.Join(" ", firstArr));
                Console.WriteLine(string.Join(" ", secondArr));
            }
    }
}