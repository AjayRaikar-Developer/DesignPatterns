using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Proxy
{
    public interface IEmployeeforProxy
    {
        public object GetEmployee(int EmployeeId);
        public bool CreateEmployee(string EmployeeType, object body);
        public bool UpdateEmployee(string EmployeeType, object body);
        public bool DeleteEmployee(string EmployeeType, object body);
    }
}
