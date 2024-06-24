using System.Xml.Linq;

namespace _02._Friend_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> newList = Console
                .ReadLine()
                .Split(", ")
                .ToList();
            string input;
            int blackListedCount = 0, lostCount = 0;
            while ((input = Console.ReadLine()) != "Report")
            {
                string[] inputArr = input
                    .Split()
                    .ToArray();
                string operation = inputArr[0];
                if (operation == "Blacklist")
                {
                    string name = inputArr[1];
                    if (newList.Contains(name))
                    {
                        
                        for (int i = 0; i < newList.Count; i++)
                        {
                            if (newList[i] == name)
                            {

                                newList[i] = "Blacklisted";
                            }
                        }
                        Console.WriteLine($"{name} was blacklisted.");
                        blackListedCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                if (operation == "Error")
                {
                    int index = int.Parse(inputArr[1]);
                    if (index >= 0 && index < newList.Count)
                    {
                        string name = newList[index];
                        if (newList[index] != "Blacklisted" && newList[index] != "Lost")
                        {
                            newList[index] = "Lost";
                            Console.WriteLine($"{name} was lost due to an error.");
                            lostCount++;
                        }
                    }
                }
                if (operation == "Change")
                {
                    int index = int.Parse(inputArr[1]);
                    string newName = inputArr[2];
                    if (index >= 0 && index < newList.Count)
                    {
                        string currentName = newList[index];
                        newList[index] = newName;
                        Console.WriteLine($"{currentName} changed his username to {newName}.");
                    }
                }
            }
            Console.WriteLine($"Blacklisted names: {blackListedCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
