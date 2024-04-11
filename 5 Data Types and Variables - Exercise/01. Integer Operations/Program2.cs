namespace IntegerOperations
{
    class Program
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(((firstNumber+secondNumber)/thirdNumber)*fourthNumber);
        }
    }
}