namespace MagicSum
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            int c = 0;
            int[] output = new int[numbers.Length]; 
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (magicNum == numbers[i] + numbers[j])
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            if (k==0)
                            {
                                output[c] = numbers[i];
                                c++;
                            }
                            else if (k==1)
                            {
                                output[c] = numbers[j];
                                c++;
                            }
                        }
                    }
                }
            }
            for (int i = 0;i < c; i++)
            {
                if(i>0 && i % 2 ==0)
                {
                    Console.WriteLine();
                }
                Console.Write(output[i] + " ");
            }
        }
    }
}