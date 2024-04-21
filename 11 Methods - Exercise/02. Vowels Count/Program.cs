namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string vowels = "";
            int vCount = 0;
            Console.WriteLine(OutputVowels(input, vowels, vCount));
        }
        static int OutputVowels(string input,string vowels, int vCount)
        {
            for (int i = 0;i<input.Length;i++)
            {
                char letter = input[i];
                if (letter == 'a' || letter == 'e' || letter == 'y' || letter == 'u' ||
                    letter == 'i' || letter == 'o' || letter == 'A' || letter == 'E' ||
                    letter == 'Y' || letter == 'U' || letter == 'I' || letter == 'O')
                {
                    vowels += letter;
                }
            }
            vCount = vowels.Length;
            return vCount;
        }
    }
}
