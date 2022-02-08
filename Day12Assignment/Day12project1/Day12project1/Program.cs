using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter a value");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b value");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Denomintor shouldn't be zero. Enter a valid input");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format is not correct.Enter a numerical value");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Given input is out of range. Enter a value between 1 to 1000000");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occured. Contact@abc.gmail.com");
            }

            
            Console.ReadLine();



        }
    }
}
