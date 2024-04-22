namespace _05._Add_and_Subtract_Second_Solution
{
    internal class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int sum = Sum(firstNumber,secondNumber);
            int substract = Substract(thirdNumber,sum);
            Console.WriteLine(substract);
        }
        static int Sum(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }
        static int Substract(int thirdNumber, int sum)
        {
            int sunstract = sum - thirdNumber;
            return sunstract;
        }
    }
}
