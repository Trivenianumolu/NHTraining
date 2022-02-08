using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Project2
{
    class Program
    {
        /****************************************************************
        Author: Triveni Anumolu
        //Purpose: Creating two classes and methods using Interface
        ******************************************************************/
        interface IShape
        {
            int CalculatePerimeter();
            int CalculateArea();
        }

        class Circle : IShape
        {
            int radius;

            public void ReadRadius()
            {
                Console.WriteLine("Enter Radius of circle");
                radius = Convert.ToInt32(Console.ReadLine());
            }

            public int CalculateArea()
            {
                return 22 * radius * radius / 7;
            }
            public int CalculatePerimeter()
            {
                return 2 * 22 * radius / 7;
            }
        }
        class Square : IShape
        {
            private int side;

            public void Readdata()
            {
                Console.WriteLine("Enter Side of square");
                side = Convert.ToInt32(Console.ReadLine());
            }

            public int CalculateArea()
            {

                return side * side;
            }
            public int CalculatePerimeter()
            {
                return 4 * side;
            }
        }

        class Triangle : IShape
        {
            private int x;
            private int y;
            private int z;

            public void ReadSide()
            {
                Console.WriteLine("Enter Side of triangle");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = Convert.ToInt32(Console.ReadLine());
            }

            public int CalculateArea()
            {

                return x * y * z;
            }
            public int CalculatePerimeter()
            {
                return x + y + z;
            }
        }
        class Rectangle : IShape
        {
            private int length;
            private int breadth;


            public void ReadSide()
            {
                Console.WriteLine("Enter Side of rectangle");
                length = Convert.ToInt32(Console.ReadLine());
                breadth = Convert.ToInt32(Console.ReadLine());
            }

            public int CalculateArea()
            {

                return length * breadth;
            }
            public int CalculatePerimeter()
            {
                return 2 * (length + breadth);
            }
        }
        internal class program
        {
            static void Main(String[] args)
            {
                Circle c1 = new Circle();
                c1.ReadRadius();
                Console.WriteLine(c1.CalculatePerimeter());
                Console.WriteLine(c1.CalculateArea());
                Square s1 = new Square();
                s1.Readdata();
                Console.WriteLine(s1.CalculatePerimeter());
                Console.WriteLine(s1.CalculateArea());
                Triangle t1 = new Triangle();
                t1.ReadSide();
                Console.WriteLine(t1.CalculatePerimeter());
                Console.WriteLine(t1.CalculateArea());
                Rectangle r1 = new Rectangle();
                r1.ReadSide();
                Console.WriteLine(r1.CalculatePerimeter());
                Console.WriteLine(r1.CalculateArea());

                Console.ReadLine();
            }
        }
    }
}





