using System;
using CafeLib.Models;
using CafeLib.Repository;
using CafeLib.Repository.XML;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<Employee> tmp = new EmployeeRep();

            var tmp1 = new Employee("Mark", "M", 10, 1);
            tmp.Add(tmp1);
        }
    }
}
