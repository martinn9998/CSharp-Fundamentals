class GreaterOfTwoValues
{
    static void Main()
    {
        string type = Console.ReadLine();
        GetMax(type);

    }
    static string GetMax(string type)
    {
        var max = 0; var maxCh = ' ';
        if (type == "int")
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                max = a;
                Console.WriteLine(max);
            }
            else
            {
                max = b;
                Console.WriteLine(max);
            }
        }
        else if (type == "char")
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            if (a > b)
            {
                maxCh = a;
                Console.WriteLine(maxCh);
            }
            else
            {
                maxCh = b;
                Console.WriteLine(maxCh);
            }
        }
        else if (type == "string")
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int aS = 0, bS = 0;
            for (int i = 0; i < a.Length; i++)
            {
                char letter = a[i];
                aS += letter;
            }
            for (int i = 0; i < b.Length; i++)
            {
                char letter = b[i];
                bS += letter;
            }
            if (aS>bS)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }

        return type;
    }

}