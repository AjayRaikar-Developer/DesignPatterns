using DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Proxy
{
    /// <summary>
    /// This a Proxy class for Employee Service 
    /// here we are checking is the user admin then only we allow any 
    /// create, update or delete operation else we reject it
    /// 
    /// Top usage of proxy pattern is for: 
    /// Blocklisting, Caching & Pre or Post Processing 
    /// </summary>
    public class EmployeeServiceProxy : IEmployeeforProxy
    {
        private readonly EmployeeService _employeeService = new EmployeeService(); 
        public bool CreateEmployee(string EmployeeType, object body)
        {    
            bool check = CheckForAdmin(EmployeeType);
            
            if (!check)
            {
                Console.WriteLine("Create Employee failed Access Denied");
                return check;
            }
            _employeeService.CreateEmployee(EmployeeType, body);

            return check;
        }

        public bool DeleteEmployee(string EmployeeType, object body)
        {
            bool check = CheckForAdmin(EmployeeType);

            if (!check)
            {
                Console.WriteLine("Delete Employee failed Access Denied");
                return check;
            }

            _employeeService.DeleteEmployee(EmployeeType, body);
           
            return check;
        }

        public object GetEmployee(int EmployeeId)
        {
            return _employeeService.GetEmployee(EmployeeId);
        }

        public bool UpdateEmployee(string EmployeeType, object body)
        {
            bool check = CheckForAdmin(EmployeeType);

            if (!check)
            {
                Console.WriteLine("Update Employee failed Access Denied");
                return check;
            }

            _employeeService.UpdateEmployee(EmployeeType, body);

            return check;
        }

        private bool CheckForAdmin(string UserType)
        {
            if (UserType.Equals("admin", StringComparison.OrdinalIgnoreCase))            
                return true;
            
            return false;
        }
    }
}
