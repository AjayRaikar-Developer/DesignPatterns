using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.Manager;

namespace DesignPatterns.Factory.FactoryMethod
{
    public class FullTimeEmployeeFactory : BaseEmployeeFactory
    {
        public FullTimeEmployeeFactory (Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            FullTimeEmployeeManager manager = new FullTimeEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}
