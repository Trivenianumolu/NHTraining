using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_number
{ 
        internal class Program
        {
            static void Main(string[] args)
            {
                int number, rem, sum = 0, temp;
                Console.WriteLine("enter number");
                number = Convert.ToInt32(Console.ReadLine());
                temp = number;
                while (number > 0)
                {
                    rem = number % 10;
                    sum = sum + (rem * rem * rem);
                    number = number / 10;
                }
                if (temp == sum)
                {
                    Console.WriteLine("{0} is an Armstrong number", temp);
                }
                else
                {
                    Console.WriteLine("{0} is not an Armsrong number", temp);
                }
                Console.ReadLine();
            }


        }
    
}
