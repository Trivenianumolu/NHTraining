using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'v';
            switch(ch)
            {
                case 'a':

                case 'e':

                case 'i':

                case 'o':

                case 'u':
                    Console.WriteLine(ch +" is a vowel");
                    break;
                default:
                    Console.WriteLine(ch + " is a consonant");
                    break;

            }
            Console.ReadLine();
        }
    }
}
