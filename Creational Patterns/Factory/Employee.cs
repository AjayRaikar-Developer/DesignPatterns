using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeType EmployeeTypeId { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal Bonus { get; set; }
        public decimal MedicalAllowance { get; set; }
        public decimal HouseAllowance { get; set; }
        public string JobDescription { get; set; }
        public string ComputerDetails { get; set; }
        public string SystemConfigurationDetails { get; set; }
    }

    public enum EmployeeType
    {
        FullTime = 1,
        Contractor = 2
    }
}
