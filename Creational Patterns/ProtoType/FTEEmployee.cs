using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProtoType
{
    public class FTEEmployee : CloneablePrototype<FTEEmployee>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public Address AddressDetails { get; set; }

        public override string ToString()
        {
            return string.Format(" Name : {0}  " + "DepartmentID : {1}  {2} ",
                this.Name, this.DepartmentID.ToString(), AddressDetails.ToString());
        }
    }
}
