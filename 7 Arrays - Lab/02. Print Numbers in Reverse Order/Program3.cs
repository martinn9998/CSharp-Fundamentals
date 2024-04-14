namespace PrintNumbersInReverseOrder
{
    class Program
    {
        public static void Main()
        {
             
            int countNumbers = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[countNumbers];
            for (int i = 0; i < countNumbers; i++)
            {
                arrNumbers[i] += int.Parse(Console.ReadLine());
            }
            Array.Reverse(arrNumbers);
            foreach (int number in arrNumbers) 
            {
                Console.Write($"{number} ");
            }
        }
    }
}