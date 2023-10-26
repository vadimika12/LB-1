using System;

namespace FunctionCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение аргумента x: ");
            double x = double.Parse(Console.ReadLine());

            double y = 1 / Math.Pow(1+x,2);

            Console.WriteLine("Значение функции y = " + y);
        }
    }
}