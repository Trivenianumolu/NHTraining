using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringListInt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            //Reading data from user
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter any value");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }
            //Find sum using for loop
            for (int i = 0; i < data.Count; i++)
                sum1 = sum1 + data[i];
            Console.WriteLine("Sum1 is " + sum1);

            //Find sum using foreach loop
            foreach (var d in data)
                sum2 = sum2+ d;
            Console.WriteLine("sum2 is " + sum2);

            //Find sum using lambda expression
            data.ForEach(p => sum3 = sum3 + p );
            Console.WriteLine("sum3 is " + sum3);
            Console.ReadLine();

        }
    }
}
