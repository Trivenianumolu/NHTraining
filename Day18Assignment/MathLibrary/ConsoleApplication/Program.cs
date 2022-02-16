using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Algebra.Factorial(-5));
            Console.WriteLine(Algebra.Palindrom(97779));
            Console.ReadLine();
        }
    }
}
