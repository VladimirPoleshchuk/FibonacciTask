using System;
using System.Diagnostics;

namespace FibonacciTask
{
    internal class Program
    {
        static Stopwatch stopwatch = new();

        static void Main()
        {
            int[] fibonacciIndces = { 5, 10, 20 };

            foreach (var fibonacciIndex in fibonacciIndces)
            {
                PrintCycleTime(fibonacciIndex);
                PrintRecursionTime(fibonacciIndex);
                Console.WriteLine();
            }
        }

        static void PrintCycleTime(int fibonacciIndex)
        {
            stopwatch.Start();

            int result = GetFibonacciCycleNumber(fibonacciIndex);

            stopwatch.Stop();

            Console.WriteLine($"Число фибоначи: {result} в {fibonacciIndex} последовательности, время поиска в цикле: {stopwatch.Elapsed}");
        }

        static void PrintRecursionTime(int fibonacciIndex)
        {
            stopwatch.Start();

            int result = GetFibonacciRecursionNumber(fibonacciIndex);

            stopwatch.Stop();

            Console.WriteLine($"Число фибоначи: {result} в {fibonacciIndex} последовательности, время поиска в рекурсии: {stopwatch.Elapsed}");
        }

        static int GetFibonacciRecursionNumber(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }

            return GetFibonacciRecursionNumber(number - 1) + GetFibonacciRecursionNumber(number - 2);
        }

        static int GetFibonacciCycleNumber(int number)
        {
            int result = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < number; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }

            return result;
        }
    }
}