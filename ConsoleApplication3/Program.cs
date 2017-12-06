using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 1;

            Swap(ref a, ref b);

            Console.WriteLine("a = {0}, b={1}", a, b);
        }
        /// <summary>
        /// Switch meanings between peremennie
        /// </summary>
        /// <param name="a">Pervaya peremennaya</param>
        /// <param name="b">Vtoraia peremennaya</param>
        private static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
} 
