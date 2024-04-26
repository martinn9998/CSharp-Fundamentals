namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Operations(numbers);
        }
        static void Operations(List<int> numbers)
        {
            string operation;
            while ((operation = Console.ReadLine()) != "end")
            {
                string[] operationArr = operation.Split()
                                .ToArray();
                switch (operationArr[0])
                {
                    case "Delete":
                        Removing(numbers, int.Parse(operationArr[1]));
                        break;
                    case "Insert":
                        Inserting(numbers, int.Parse(operationArr[2]), int.Parse(operationArr[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    
        static void Removing(List<int> numbers, int number)
        {
            numbers.Remove(number);
            for (int d = 0;d < numbers.Count;d++)
            {
                if (numbers[d]==number)
                {
                    numbers.Remove(number);
                    d = 0;
                }
            }
        }
        static void Inserting(List<int> numbers, int number, int index)
        {
            numbers.Insert(number, index);
        }
    }
}
