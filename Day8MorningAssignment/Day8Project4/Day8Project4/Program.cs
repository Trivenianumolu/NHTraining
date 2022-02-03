using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project4
{
    class Department
    {
        public int Id;
        public string name;
        public int empcount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************
             Author: Triveni Anumolu
            Purpose: Creating a department class and adding variables and printing dept id, dept name 
            ******************************************************************/
            List<Department> dept = new List<Department>()
            {
                new Department() { Id = 101, name ="Administration", empcount = 100},
               
                new Department() { Id = 201, name ="Production", empcount = 50},
                new Department() { Id = 301, name ="Inspection",empcount = 30},
                new Department() { Id = 401, name ="Manufacturing", empcount = 50},
                new Department() { Id = 501, name ="Finance",  empcount = 70}
            };



            //Using For Loop
            for (int i = 0; i < dept.Count; i++)
            {
                if (dept[i].empcount > 50)
                    Console.WriteLine($"name={dept[i].name}, Id={dept[i].Id}");
            }

            //Using foreach loop
            foreach (var d in dept)
            {
                if (d.empcount  > 50)
                    Console.WriteLine($"name={d.name}, Id={d.Id}");
            }
            //using Lambda Expression
            dept.Where(x => x.empcount > 50).ToList().ForEach(x => Console.WriteLine($"name={x.name}, Id={x.Id}"));


            //Even numbers using LINQ Query
            var result = from v in dept
                         where v.empcount >50
                         select v;
            result.ToList().ForEach(x => Console.WriteLine($"name={x.name}, Id={x.Id}"));

            Console.ReadLine();

        }
    }
}
       
