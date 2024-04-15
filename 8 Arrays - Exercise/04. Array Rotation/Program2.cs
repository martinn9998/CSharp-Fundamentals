namespace ArrayRotation
{
    class Program
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times % arr.Length; i++)
            {
                int firstNumber = arr[0];
                  
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length-1] = firstNumber;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}