namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input;
            int countShot = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(input);
                if (targetIndex >= 0 && targetIndex < arr.Length && (arr[targetIndex]) != -1)
                {
                    int value = arr[targetIndex];
                    arr[targetIndex] = -1;
                    countShot++;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] > value)
                        {
                            arr[i] -= value;
                        }
                        else
                        {
                            arr[i] += value;
                        }
                    }
                }
            }
            Console.Write($"Shot targets {countShot} -> " + string.Join(" ", arr));
        }
    }
}
