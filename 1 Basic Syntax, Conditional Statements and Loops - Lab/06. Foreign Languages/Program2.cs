namespace ForeignLanguages
{
    class Programm
    {
        public static void Main()
        {
            var countryName = Console.ReadLine();
            switch (countryName)
            {
                case "England":
                    Console.WriteLine("English");
                    break;
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default: 
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}