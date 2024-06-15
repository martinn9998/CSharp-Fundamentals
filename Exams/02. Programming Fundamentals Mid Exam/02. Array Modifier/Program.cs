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

                }
            }
        }
    }
}