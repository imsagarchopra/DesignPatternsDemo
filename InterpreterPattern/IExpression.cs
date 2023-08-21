using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    //This is going to be an interface that defines the Interpret operation, which must be implemented by each subclass.
    public interface IExpression
    {
        void Evaluate(Context context);
    }
}
