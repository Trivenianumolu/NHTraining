using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Function
{
    internal class Program
    {
        public static bool Arm(int number)
        {
            int temp, sum = 0, rem;
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;

            }
            if (temp == sum)
            {
                return true;

            }
            else
            {
                return false;

            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (Arm(number) == true)
                Console.WriteLine("{o} is Armstrong number", number);
            else
                Console.WriteLine("{0} is not Armstrong number", number);
            Console.ReadLine();


        }
    }
}

