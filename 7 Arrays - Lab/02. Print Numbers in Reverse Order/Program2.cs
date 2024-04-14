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
                arrNumbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = countNumbers-1;i >= 0; i--) 
            {
                Console.Write(arrNumbers[i] + " ");
            }
        }
    }
}