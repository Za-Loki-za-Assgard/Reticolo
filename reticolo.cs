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
        static void numGuessing()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 99)
            {
                int piv;
                int max = 99;
                int min = 1;

                while (true)
                {
                    piv = (min + max) / 2;

                    if (num == piv)
                    {
                        Console.Write("res: " + num + "\n");
                        break;
                    }

                    if (num > piv)
                    {
                        min = piv;
                    }

                    else if (num < piv)
                    {
                        max = piv;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            numGuessing();
        }
    }
}
