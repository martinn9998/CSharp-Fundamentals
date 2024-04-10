namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        public static void Main()
        {
            string[] numbersToText =
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eighth",
                "nine"
            };
            var numbers = int.Parse(Console.ReadLine());
            var lastDigit = numbers % 10;
            Console.WriteLine(numbersToText[lastDigit]);
        }
    }
}
