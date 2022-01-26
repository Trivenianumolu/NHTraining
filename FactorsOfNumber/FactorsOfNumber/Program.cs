using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadLine();
        }
        
    }
}
