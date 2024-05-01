namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    if (!dict.ContainsKey(str[i]))
                    {
                        dict[str[i]] = 0;
                    }
                    dict[str[i]]++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, 
                dict.Select(x => $"{x.Key} -> {x.Value}")));
        }
    }
}
