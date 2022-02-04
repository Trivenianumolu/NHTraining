using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Project3
{
    class A
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public float Sub(float a, float b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            Console.WriteLine(a1.Add(5,6));
            Console.WriteLine(a1.Sub(2.2f,1.2f));
            Console.ReadLine();
        }
    }
}
