using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project1
{
    class A
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }

    }
    class B : A
    {
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
    class C : B
    {
        public int Div(int a, int b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c1 = new C();
            Console.WriteLine(c1.Add(3,7));
            Console.WriteLine(c1.Sub(3, 1));
            Console.WriteLine(c1.Mul(3, 9));
            Console.WriteLine(c1.Div(9,3));
            Console.ReadLine();
        }
    }
}
