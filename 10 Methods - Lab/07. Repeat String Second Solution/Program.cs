namespace _07._Repeat_String_Second_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int repeatingsCount = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(str, repeatingsCount));
        }
        static string RepeatString(string str, int repeatingCount)
        {
            string result = 
                string.Join("", Enumerable.Repeat(str, repeatingCount));
            return result;
        }
    }
}
