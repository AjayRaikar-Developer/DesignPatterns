using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Proxy
{
    public class EmployeeService : IEmployeeforProxy
    {
        public bool CreateEmployee(string EmployeeType, object body)
        {
            Console.WriteLine("Created Employee in DB");
            return true;
        }

        public bool DeleteEmployee(string EmployeeType, object body)
        {
            Console.WriteLine("Deleted Employee in DB");
            return true;
        }

        public object GetEmployee(int EmployeeId)
        {
            return new { EmployeeId = 1, Name = "Kumar" };
        }

        public bool UpdateEmployee(string EmployeeType, object body)
        {
            Console.WriteLine("Updated Employee in DB");
            return true;
        }
    }
}
