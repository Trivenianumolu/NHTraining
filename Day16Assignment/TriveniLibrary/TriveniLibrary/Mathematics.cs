using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriveniLibrary
{
    public class Mathematics
    {
        int n;
        public void ReadInput()
        {
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public int Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
            //Console.WriteLine("Factorial of {0} is {1}", n, fact);

        }
    }
    
}

