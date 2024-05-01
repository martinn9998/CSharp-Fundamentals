namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> courseArgs = input
                    .Split(" : ")
                    .ToList();
                string courseName = courseArgs[0];
                string studentNmae = courseArgs[1];
                if (!dict.ContainsKey(courseName))
                {
                    dict[courseName] = new List<string>();
                }
                dict[courseName] = new List<string>();
            }
            foreach (var item in dict.OrderByDescending(X => X.Value.Count()))
            {
                string courseName = item.Key;
                int studsCount = item.Value.Count();
                Console.WriteLine($"{courseName}: {studsCount}");
                foreach (var studs in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {studs}");
                }
            }
        }
    }
}
