namespace EvenNumber
{
    class Programm
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            while (true)
            {
                number = Math.Abs(number);
                if (number%2==0)
                {
                    Console.WriteLine($"The number is: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    number = int.Parse(Console.ReadLine());
                }
            }
            
        }
    }
}