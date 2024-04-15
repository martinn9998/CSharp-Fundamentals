namespace CommonElements
{
    class Program
    {
        public static void Main()
        {
            string[] arrWords1 = Console.ReadLine()
                .Split()
                .ToArray();
            string[] arrWords2 = Console.ReadLine()
                .Split()
                .ToArray();
            for (int i = 0; i < arrWords2.Length; i++)
            {
                for (int j = 0; j < arrWords1.Length; j++)
                {
                    if (arrWords2[i] == arrWords1[j])
                    {
                        Console.Write(arrWords2[i] + " ");
                        break;
                    }
                }
            }
        }
    }
}