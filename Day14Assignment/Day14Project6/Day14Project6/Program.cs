using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project6
{
    /***********************************************
     * Author:Triveni Anumolu
     * Purpose:Finding force using auto-implemented property
     * *************************************************/
    class Calculation
    {
        private int mass;
        private int acceleration;
        private int force;
        public int Force
        {
            get
            {
                return force = mass * acceleration;
            }
        }
   
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            cal.mass = 12;
            cal.acceleration = 100;
            Console.WriteLine(cal.Force);
            Console.ReadLine();
        }
    }
}
