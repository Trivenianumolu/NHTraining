using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;
namespace BusinessLogicLibrary
{
    //Author: Triveni Anumolu
    /************Purpose:Business Logic Layer Library************/
    public static class EmployeeBLL
    {
        /// <summary>
        /// This method is used to Add Employees
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="empName"></param>
        /// <param name="eSal"></param>
        /// <param name="empAge"></param>
        /// <returns></returns>
        public static bool AddEmployee(int empId,string empName,int eSal,int empAge)
        {
            //to do


            //All success call DAL
            var result=EmployeeDAL.AddEmployee(empId,empName,eSal,empAge);
            return result;
        }
        /// <summary>
        /// This method is used to search employee by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<string> SearchById(int id)
        {
            var result=EmployeeDAL.SearchById(id);
            return result;
        }
        /// <summary>
        /// This method is used to search employee by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<string> SearchByName(string name)
        {
            var result= EmployeeDAL.SearchByName(name);
            return result;
        }
        /// <summary>
        /// This method is used to Display all Employees details 
        /// </summary>
        /// <returns></returns>
        public static string[] DisplayAllEmployees()
        {
            var result=EmployeeDAL.DisplayAllEmployees();
            return result;
        }
    }
}
