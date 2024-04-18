namespace EncryptSortAnd_PrintArrayThirdSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int[] sums = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                string name = Console.ReadLine();
                int totalSum = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == 'a' || name[j] == 'e' ||
                        name[j] == 'u' || name[j] == 'i' ||
                        name[j] == 'o' ||
                        name[j] == 'A' || name[j] == 'E' ||
                        name[j] == 'U' || name[j] == 'I' ||
                        name[j] == 'O')
                    {
                        totalSum += (char)name[j] * name.Length;
                        sums[i] = totalSum;
                    }
                    else
                    {
                        totalSum += (char)name[j] / name.Length;
                        sums[i] = totalSum;
                    }
                }
            }
            Array.Sort(sums);
            foreach (var item in sums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
