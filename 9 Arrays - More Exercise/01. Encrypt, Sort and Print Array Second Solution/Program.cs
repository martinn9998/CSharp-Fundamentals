namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrInt = new int[n];
            for (int p = 0; p < n; p++)
            {
                string str = Console.ReadLine();
                int sum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    int currentNumberFromChar = 0;
                    char letter = str[i];
                    if (letter == 'a' || letter == 'e' || letter == 'o' ||
                        letter == 'i' || letter == 'u' ||
                        letter == 'A' || letter == 'E'
                        || letter == 'O' ||
                        letter == 'I' || letter == 'U'
                        )
                    {
                        currentNumberFromChar = letter;
                        currentNumberFromChar *= str.Length;
                        sum += currentNumberFromChar;

                    }
                    else
                    {
                        currentNumberFromChar = letter;
                        currentNumberFromChar /= str.Length;
                        sum += currentNumberFromChar;
                    }
                }
                arrInt[p] = sum;
            }
            int[] output = Output(arrInt);
            foreach (int o in output)
            {
                Console.WriteLine(o);
            }

        }
        static int[] Output(int[] arrInt)
        {
            int[] output = new int[arrInt.Length];
            output = arrInt.OrderBy(x => x).ToArray();
            return output;
        }
    }

}