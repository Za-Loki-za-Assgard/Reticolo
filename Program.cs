using System;
using System.Diagnostics;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int x1 = 1, x2 = 1;
            Console.WriteLine("Введите количество чисел Фибоначчи");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            Console.WriteLine(n + " первых членов последовательности Фибоначчи: ");
            Console.Write(x1 + " ");
            for (int i = 1; i < n; i++)
            {
                x2 += x1;
                x1 = x2 - x1;
                Console.Write(x1 + " ");
            }
        }
    }
}
