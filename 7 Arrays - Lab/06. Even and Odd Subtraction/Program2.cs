namespace EvenAndOddSubtraction
{
    class Program
    {
        public static void Main()
        {
            int[] arrNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                if (arrNumbers[i] % 2 == 0)
                {
                    sumEven += arrNumbers[i];
                }
                else
                {
                    sumOdd += arrNumbers[i];
                }
            }
            int subtraction = sumEven - sumOdd;
            Console.WriteLine(subtraction);
        }
    }
}