using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14project3
{
    class Program
    {
        /**************************************************************************
          Author:Triveni Anumolu
        Purpose:Printing the values which are not divisible by 3 using continue
        ****************************************************************************/
         
        static void Main(string[] args)
        {
            int n = 30;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.Write(i +" ");
                
            }
            Console.ReadLine();
        }
    }
}
