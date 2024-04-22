namespace _06._Middle_Characters_Second_Solution
{
    internal class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Console.WriteLine(MiddleElements(str));
        }
        static string MiddleElements(string str)
        {
            string middle = string.Empty;
            if(str.Length % 2 == 0)
            {
                middle = str[(str.Length / 2) -1] + str[str.Length / 2].ToString();
            }
            else
            {
                middle = str[str.Length /2].ToString();
            }
            return middle;
        }
    }
}
