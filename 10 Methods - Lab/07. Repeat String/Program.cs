
public class RepeatString
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
            string result = "";
         RepeatTheString(str, count);
    }

    

    private static string RepeatTheString(string str, int count)
    {
        
        string result = "";
        for (int i = 0; i < count; i++)
        {
            result += str;
        }
        Console.WriteLine(result);
        return result;

    }
    
}