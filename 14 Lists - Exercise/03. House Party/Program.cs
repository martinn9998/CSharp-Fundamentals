using System;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            GuestOperations(n);
        }
        static void GuestOperations(int n)
        {
            List<string> guests = new List<string>(n);
            for (int i = 0; i < n; i++)
            {
                string operation = Console.ReadLine();
                string[] operationArr = operation.Split(' ')
                                .ToArray();
                string name = operationArr[0];
                switch (operationArr[2])
                {
                    case "going!":
                        Adding(guests,name);
                        break;
                    case "not":
                        Removing(guests, name);
                        break;
                }
            }
            Printing(guests);
        }
        static void Printing(List<string> guests)
        {
            foreach (string s in guests)
            {
                Console.WriteLine(s);
            }
        }
        static void Adding(List<string> guests, string name)
        {
            bool found = false;
            for (int i = 0; i < guests.Count; i++)
            {
                if (guests[i] == name)
                {
                    found = true;
                }
            }
            if (found)
            {
                Console.WriteLine($"{name} is already in the list!");
                found = false;
            }
            else
            {
                guests.Add(name);
            }
        }
        static void Removing(List<string> guests, string name)
        {
            bool found = false;
            for (int i = 0;i < guests.Count; i++)
            {
                if (guests[i]==name)
                {
                    found = true;
                }
            }
            if (found)
            {
                guests.Remove(name);
            }
            else
            {
                Console.WriteLine($"{name} is not in the list!");
            }
        }
    }
}
