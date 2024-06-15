namespace ArrayModifier
{
    class Program
    {
        public static void Main()
        {
            int[] arr = Console 
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input.Split();
                string process = inputArr[0];
                if (process == "swap")
                {
                    int number1 = arr[int.Parse(inputArr[1])];
                    int number2 = arr[int.Parse(inputArr[2])];
                    arr[int.Parse(inputArr[1])] = number2;
                    arr[int.Parse(inputArr[2])] = number1;
                }
                else if (process == "multiply")
                {
                     
                }
                else if (process == "decrease" &&)
                {
                     
                }
                else if (process >= )
            }
        }
    }
}