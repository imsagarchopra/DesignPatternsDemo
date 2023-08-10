using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class PermanentEmployee : Employee
    {
        public override Employee GetDeepCopy()
        {
            PermanentEmployee employee = (PermanentEmployee)this.MemberwiseClone();
            employee.EmpAddress = this.EmpAddress.GetClone();
            return employee;
        }

        public override Employee GetShallowCopy()
        {
            return (PermanentEmployee)this.MemberwiseClone();
        }
    }
}
