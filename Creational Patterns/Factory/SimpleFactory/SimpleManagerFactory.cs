using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.Manager;

namespace DesignPatterns.Factory.SimpleFactory
{
    public class SimpleManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(Employee employee)
        {
            IEmployeeManager returnValue = null;

            if (employee.EmployeeTypeId == EmployeeType.FullTime)
            {
                returnValue = new FullTimeEmployeeManager();
            }
            else if (employee.EmployeeTypeId == EmployeeType.Contractor)
            {
                returnValue = new ContractEmployeeManager();
            }

            return returnValue;
        }

    }
}
