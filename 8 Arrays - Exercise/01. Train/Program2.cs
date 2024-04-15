namespace Train
{
    class Program
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[numbers];
            for (int i = 0;i < numbers;i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", arrNumbers));
            Console.WriteLine(arrNumbers.Sum());
        }
    }
}