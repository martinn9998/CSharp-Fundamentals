using System;
namespace _03._Calculations_Second_Solution
{
    internal class Program
    {
        
            static void Main()
            {
                string operation = Console.ReadLine();
                double firstNumber = double.Parse(Console.ReadLine());
                double secondNumber = double.Parse(Console.ReadLine());
                if (operation== "subtract")
                {
                    Substract(firstNumber, secondNumber);
                }
                else if (operation == "add")
                {
                    Add(firstNumber, secondNumber);
                }
                else if(operation == "divide")
                {
                    Divide(firstNumber, secondNumber);
                }
                else if(operation == "multiply")
                {
                    Multiply(firstNumber, secondNumber);
                }
            }
            static void Substract(double firstNumber, double secondNumber)
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            static void Add(double firstNumber, double secondNumber)
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
            static void Divide(double firstNumber, double secondNumber)
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            static void Multiply(double firstNumber, double secondNumber)
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
        }
    }

