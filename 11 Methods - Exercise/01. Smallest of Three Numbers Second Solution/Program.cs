namespace _01._Smallest_of_Three_Numbers_Second_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSmallestNumber(firstNumber, secondNumber
                , thirdNumber));
        }
        static int GetSmallestNumber(int firstNumber, int secondNumber, 
            int thirdNumber)
        {
            int smallestNumber = Math.Min(Math.Min(firstNumber, secondNumber), 
                thirdNumber);
            return smallestNumber;
        }
    }
}
