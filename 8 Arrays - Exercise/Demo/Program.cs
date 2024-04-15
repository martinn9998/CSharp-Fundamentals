class MagicSum
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int magic = int.Parse(Console.ReadLine());
        int sum = 0;
        int length = nums.Length;
        int[] condensed = new int[length];
        int c = 0;
        for (int x1 = 0; x1 < length; x1++)
        {
            for (int x2 = x1; x2 < length; x2++)
            {

                if (x1 == x2)
                {
                    continue;
                }
                if (magic == nums[x1] + nums[x2])
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 0)
                        {
                            condensed[c] = nums[x1];
                            c++;
                        }
                        if (i == 1)
                        {
                            condensed[c] = nums[x2];
                            c++;
                        }
                    }
                }


            }
        }
        for (int i = 0; i < c; i++)
        {
            if (i > 0 && i % 2 == 0)
            {
                Console.WriteLine();
            }
            Console.Write($"{condensed[i]} ");

        }

    }
}