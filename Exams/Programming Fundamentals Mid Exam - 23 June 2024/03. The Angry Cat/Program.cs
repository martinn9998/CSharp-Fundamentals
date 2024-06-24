namespace _03._The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> newList = Console
                .ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();
            int index = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            List<int> leftSide = new List<int>();
            List<int> rightSide = new List<int>();
            for (int i = 0; i < index ; i++)
            {
                leftSide.Add(newList[i]);
            }
            for (int i = index + 1;i < newList.Count; i++)
            {
                rightSide.Add(newList[i]);
            }
            int value = newList[index];
            int leftSum = 0;
            int rightSum = 0;
            if (typeOfItems == "cheap")
            {
         
                foreach (int item in leftSide)
                {
                    if (item < value)
                    {
                        leftSum += item;
                    }
                }
                foreach (int item in rightSide)
                {
                    if (item < value)
                    {
                        rightSum += item;
                    }
                }
            }
            else if (typeOfItems == "expensive")
            {
                foreach (int item in leftSide)
                {
                    if (item >= value)
                    {
                        leftSum += item;
                    }
                }
                foreach (int item in rightSide)
                {
                    if (item >= value)
                    {
                        rightSum += item;
                    }
                }
            }
            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}
