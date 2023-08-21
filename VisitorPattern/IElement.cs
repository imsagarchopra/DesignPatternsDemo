using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    // The Element interface declares an Accept method that should take the
    // base visitor interface as an argument.
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
