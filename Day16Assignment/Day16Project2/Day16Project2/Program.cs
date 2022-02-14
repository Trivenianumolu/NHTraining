using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project2
{
    class Calculation
    {
        public  void Factorial()
        {
            int n, fact=1;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of {0} is {1}", n,fact); 

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            cal.Factorial();
            Console.ReadLine();
        }
    }
}
