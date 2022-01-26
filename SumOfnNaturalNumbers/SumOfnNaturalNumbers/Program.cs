using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfnNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("Enter any number ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                sum += i;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
