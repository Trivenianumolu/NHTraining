using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20project1
{
    class Program
    {
        public delegate void Del(int a, int b);



        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
                Del d = new Del(Add);
                d += Sub;
            d += Mul;
            d += Div;
            d(8, 4);
            d(34, 5);
            Console.ReadLine();
        }
    }
    
}
