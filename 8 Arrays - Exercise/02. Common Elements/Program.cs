class CommonElements
{
    static void Main(string[] args)
    {
        string[] arr1 = Console.ReadLine()
            .Split(' ');
        string[] arr2 = Console.ReadLine()
            .Split(' ');
        int k = 0;
        string[] output = new string[arr2.Length];
        for (int x1 = 0; x1 < arr2.Length; x1++)
        {
            for (int x2 = 0; x2 < arr1.Length; x2++)
            {
                if (arr2[x1] == arr1[x2])
                {
                    output[k] = arr2[x1];
                    k++;
                }
            }
        }
        string[] output0 = new string[k];
        for (int z = 0; z < k; z++)
        {
            output0[z] = output[z];
            Console.Write(output0[z] + " ");
        }

    }
}
