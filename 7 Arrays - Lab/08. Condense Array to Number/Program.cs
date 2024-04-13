class ArrayToNumber
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int sum = 0;
        int[] condensed = new int[nums.Length];
        int length = nums.Length - 1;
        for (int x1 = length; x1 > 0; x1--)
        {
            for (int x2 = 0; x2 < x1; x2++)
            {
                condensed[x2] = nums[x2] + nums[x2 + 1];
                nums[x2] = condensed[x2];
            }    
        }
        Console.WriteLine(nums[0]);

    }
}