using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulTableUsingWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while(i<=10)
            {
                Console.WriteLine(n+"x"+i+"="+n*i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
