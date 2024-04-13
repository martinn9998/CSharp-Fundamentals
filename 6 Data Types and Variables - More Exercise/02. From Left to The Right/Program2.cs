namespace FromLeftToTheRight
{
    class Programm
    {
        public static void Main()
        {
            int inputLinesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputLinesCount; i++)
            {
                string number = Console.ReadLine();
                string[] splittedNumbers = number.Split(' ');

                long leftNumber = long.Parse(splittedNumbers[0]);
                long rightNumber = long.Parse(splittedNumbers[1]);

                long biggestValue = leftNumber;
                if (rightNumber > leftNumber)
                {
                    biggestValue = rightNumber;
                }

                long digitSum = 0;
                while (biggestValue != 0)
                {
                    digitSum += biggestValue % 10;
                    biggestValue /= 10;
                }
                Console.WriteLine($"{Math.Abs(digitSum)}");
            }
        }
    }
}
