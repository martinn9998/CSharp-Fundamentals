namespace AddAndSubstract
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int sum = Summ(n1, n2);
            int substract = Subtract(sum,n3);
            Console.WriteLine(substract);
        }
        private static int Summ(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        private static int Subtract(int sum, int n3)
        {
        int subtract = sum - n3;
            return subtract;
        }
    }
}