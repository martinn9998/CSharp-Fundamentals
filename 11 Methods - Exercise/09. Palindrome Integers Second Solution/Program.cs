﻿namespace _09._Palindrome_Integers_Second_Solution
{
    internal class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            while (str != "END")
            {
                Console.WriteLine(CheckingPalindromeIntegers(str).ToString().ToLower());
                str = Console.ReadLine();
            }
        }
        static bool CheckingPalindromeIntegers(string str)
        {
            string reversed = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i].ToString();
            }
            if (reversed == str)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
