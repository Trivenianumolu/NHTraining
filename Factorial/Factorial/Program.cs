using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, fact= 1;
            Console.WriteLine("Enter any number ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = n; i >= 1; i--)
                fact*= i;
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
