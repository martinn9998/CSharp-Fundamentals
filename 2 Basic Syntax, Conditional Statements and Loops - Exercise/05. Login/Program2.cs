namespace Login
{
    class Program
    {
        public static void Main()
        {
            var username = Console.ReadLine();
            var password = Reversed(username);
            var incorrect = 0;
            bool blocked = false;
            string input;
            while ((input = Console.ReadLine())!=password)
            {
                incorrect++;
                if (incorrect == 4)
                {
                    blocked = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            if (blocked)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
        private static string Reversed(string username)
        {
            string reversed = "";
            for (int i = username.Length-1; i >= 0; i--)
            {
                char letter = username[i];
                reversed += letter;
            }
            return reversed;
        }
    }
}