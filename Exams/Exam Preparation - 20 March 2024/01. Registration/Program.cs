namespace _01._Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Registration")
            {
                string[] arr = command
                    .Split()
                    .ToArray();
                if (arr[0] == "Letters")
                {
                    string lowerCase = username;
                    char[] arrChar = lowerCase.ToCharArray();
                    foreach (char character in arrChar)
                    {
                        char.ToUpper(character);
                    }

                    Console.WriteLine(string.Join("", arrChar));
                }
                else if (arr[0] == "Reverse")
                {
                    int startIndex = int.Parse(arr[1]);
                    int endIndex = int.Parse(arr[2]);
                    
                    char[] arrUsername = username.ToCharArray();
                    if ((startIndex >= 0 && startIndex < arrUsername.Length) && (endIndex >= 0 && endIndex < arrUsername.Length) )
                    {
                        int arrLength = endIndex - startIndex;
                        char[] newCharArr = new char[arrLength];
                        int r = startIndex;
                        for (int i = 0; r >= endIndex ; i++, r++)
                        {
                            newCharArr[i] = arrUsername[r];
                        }
                        Array.Reverse(newCharArr);
                        Console.WriteLine(string.Join("", newCharArr));
                    }
                }
                else if (arr[0] == "Substring")
                {

                }

            }
        }
    }
}
