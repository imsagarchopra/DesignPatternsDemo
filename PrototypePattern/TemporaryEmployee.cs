using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class TemporaryEmployee : Employee
    {
        public override Employee GetDeepCopy()
        {
            TemporaryEmployee employee = (TemporaryEmployee)this.MemberwiseClone();
            employee.EmpAddress = this.EmpAddress.GetClone();
            return employee;
        }

        public override Employee GetShallowCopy()
        {
            return (TemporaryEmployee)this.MemberwiseClone();
        }
    }
}
