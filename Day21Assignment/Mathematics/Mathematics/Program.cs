using Mathematics.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient web = new WebService1SoapClient();
            Console.WriteLine(web.Add(2,3));
            Console.WriteLine(web.Mul(3,4));
            Console.WriteLine(web.Div(5,5));
            Console.WriteLine(web.Factorial(6));  
            Console.ReadLine(); 
        }
    }
}
