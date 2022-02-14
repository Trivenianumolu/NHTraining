using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project5
{
    class Palindrome
    {
        int n;
        
        public void ReadInput()
        {
             
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());

        }
        public void Check()
        {
            int temp = n;
            int rem, sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("{0} is a Palindrome", temp);
            else
                Console.WriteLine("{0} is not a Palindrome", temp);
        } 

    }
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            p.ReadInput();
            p.Check();
            Console.ReadLine();

        }
    }
}
