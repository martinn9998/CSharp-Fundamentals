﻿using System.Text;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            var sb = new StringBuilder();
            var sbTwo = new StringBuilder();
            while ((word = Console.ReadLine()) != "end")
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    sbTwo.Append(word[i]);
                }
                sb.AppendLine($"{word} = {sbTwo}");
                sbTwo.Clear();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}