using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Algebra
    {
        public static int Factorial(int n)
        {

            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return -9999;
            else
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
            
        }
        public static string Palindrom(int n)
        {
            int rem, sum = 0;
            int temp = n;
            while(n>0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            if (temp == sum)
                return "Palindrom";

            else
                return "Not a Palindrom";  

        }
    }
}
