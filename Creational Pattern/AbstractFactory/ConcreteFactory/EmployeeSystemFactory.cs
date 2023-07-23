using DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returnValue = null;
            if (e.EmployeeTypeId == EmployeeType.FullTime)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new MACLaptopFactory();
                }
                else
                {
                    returnValue = new MACFactory();
                }
            }
            else if (e.EmployeeTypeId == EmployeeType.Contractor)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                    returnValue = new DellFactory();
            }
            return returnValue;
        }
    }
}
