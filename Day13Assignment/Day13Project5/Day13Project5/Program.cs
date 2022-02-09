using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project5
{
    class Program
    {
        /**********************************************************
         Author: Triveni Anumolu
        Purpose:printing  elements of a jagged array
        **********************************************************/
        static void Main(string[] args)
        {
            char[][] ch = new char[3][];
            ch[0] = new char[] { 'h', 'i' };
            ch[1] = new char[] { 'h', 'e' ,'l','l','o'};
            ch[2] = new char[] { 'h', 'o','w','a','r','e','y','o','u'};
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<ch[i].Length;j++)
                {
                    Console.Write(ch[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
