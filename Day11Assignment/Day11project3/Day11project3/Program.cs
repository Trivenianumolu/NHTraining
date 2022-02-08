using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11project3
{
    class mathematics
    {
        //Triveni Anumolu
        //Purpose: creating a class with three static methods
        public static int add(int a, int b)
        {
            return a + b;

        }
        public static int mul(int c, int d)
        {
            return c * d;
        }
        public static int sub(int e, int f)
        {
            return e - f;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mathematics.add(45, 29));
            Console.WriteLine(mathematics.mul(6, 3));
            Console.WriteLine(mathematics.sub(12, 22));
            Console.ReadLine();
        }
    }
}







