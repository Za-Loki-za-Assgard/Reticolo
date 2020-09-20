using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Factorial()
        {
            Console.WriteLine("Input calculated value");
            int x = Convert.ToInt32(Console.ReadLine());
            int factorial = x;
            for (int i = x - 1; i > 1; i--)
                factorial *= i;
            Console.WriteLine($"{x}!={ factorial}");
            
        }

        static void Main(string[] args)
        {
            Factorial();
        }
    }
}
