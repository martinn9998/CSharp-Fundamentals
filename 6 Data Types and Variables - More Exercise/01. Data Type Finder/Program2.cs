namespace DataTypeFinder
{
    class Program
    {
        public static void Main()
        {
            string input;
            string dataType = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                if (int.TryParse(input, out int integerNumber))
                {
                    dataType = "integer type";
                }
                else if (float.TryParse(input, out float floaingtNumber))
                {
                    dataType = "floating point type";
                }
                else if (char.TryParse(input, out char character))
                {
                    dataType = "character type";
                }
                else if (bool.TryParse(input, out bool booleanText))
                {
                    dataType = "boolean type";
                }
                else
                {
                    dataType = "string type";
                }
                Console.WriteLine(input + " is " + dataType);
            }
        }
    }
}