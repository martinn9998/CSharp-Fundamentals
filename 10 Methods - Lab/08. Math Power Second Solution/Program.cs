namespace _08._Math_Power_Second_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerNumber(number, power));
        }
        static double PowerNumber(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
