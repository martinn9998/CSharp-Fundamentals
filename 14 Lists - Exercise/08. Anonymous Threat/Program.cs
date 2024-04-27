namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console
                .ReadLine()
                .Split()
                .ToList();
            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "merge":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        Merging(data, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(command[1]);
                        int partitions = int.Parse(command[2]);
                        Dividing(data, index, partitions);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", data));
        }
        static void Merging(List<string> data, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex > data.Count)
            {
                startIndex = data.Count - 1;
            }
            if (endIndex > data.Count)
            {
                endIndex = data.Count - 1;
            }
            else if (endIndex > data.Count )
            {

            }
        }
    }
}
