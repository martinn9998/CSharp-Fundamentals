namespace _01._Data_Types_Second_Solution
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    Console.WriteLine(IsInt());
                    break;
                case "real":
                    Console.WriteLine($"{isReal():f2}");
                    break;
                case "string":
                    Console.WriteLine(isString());
                    break;
            }
        }
        static int IsInt()
        {
            int number = int.Parse(Console.ReadLine());
            number *= 2;
            return number;
        }
        static double isReal()
        {
            double number = Math.Abs(double.Parse(Console.ReadLine()));
            number *= 1.5;
            return number;
        }
        static string isString()
        {
            string word = Console.ReadLine();
            string finalWord = "$" + word + "$";
            return finalWord;
        }
    }
}
