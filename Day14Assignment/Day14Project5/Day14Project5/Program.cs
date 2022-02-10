using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project5
{
    class Calculation
    {
        /*********************************************
         * Author: Triveni Anumolu
         * Purpose:Finding force using normal properties
         * **********************************************/
        private int mass;
        private int acceleration;

        private int force;
        //Normal Properties
        public int Mass
        {
            set
            {
                mass = value;
            }
        }
        public int Acceleration
        {
            set
            {
                acceleration = value;
            }
        }
        public int Force
        {
            get
            {
                return force = mass * acceleration;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            cal.Mass = 100;
            cal.Acceleration = 20;
            Console.WriteLine(cal.Force);
            Console.ReadLine();
        }
    }
}
