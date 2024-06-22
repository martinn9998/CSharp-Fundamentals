namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> newList = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arrInput = input
                    .Split()
                    .ToArray();
                switch (arrInput[0])
                {
                    case "Shoot":
                        int index = int.Parse(arrInput[1]);
                        int power = int.Parse(arrInput[2]);
                        if (index >= 0 && index < newList.Count)
                        {
                            newList[index] -= power;
                            if (newList[index] <= 0)
                            {
                                newList.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        index = int.Parse(arrInput[1]);
                        int value = int.Parse(arrInput[2]);
                        if (index >= 0 && index < newList.Count)
                        {
                            newList.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                            break;
                    case "Strike":
                        index = int.Parse(arrInput[1]);
                        int radius = int.Parse(arrInput[2]);
                        if (index >= 0 && index < newList.Count)
                        {
                            int smallestIndex = index - radius;
                            int biggestIndex = index + radius;
                            if (smallestIndex >= 0 && biggestIndex < newList.Count)
                            {
                                newList.RemoveRange(smallestIndex, biggestIndex - smallestIndex + 1);
                            }
                            else
                            {
                                Console.WriteLine("Strike missed!");
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join("|", newList));
        }
    }
}
