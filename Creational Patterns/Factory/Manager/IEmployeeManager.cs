using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Manager
{
    public interface IEmployeeManager
    {
        public decimal GetPay();
        public decimal GetBonus();
    }
}
