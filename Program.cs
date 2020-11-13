using System;
using System.Numerics;

namespace _12.examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            string consoleInputLine = Console.ReadLine();
            int n = int.Parse(consoleInputLine);

            Console.Write("m = ");

            consoleInputLine = Console.ReadLine();
            int m = int.Parse(consoleInputLine);

            n = Math.Min(n, m);
            m = Math.Max(n,m);

            //int min = Math.Min(n, m);
            //int max = Math.Max(n, m);

            //n = min;
            //m = max;

                int num = n;
                decimal product = 1;
                do
                {
                    product *= num;
                    num++;

                } while (num <= m);
                Console.WriteLine("product[n..m] = " + product);
            
           
        }

    }
}
