using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    //This is going to be a Concrete class that implements the Expression Interface.
    //The following Concrete YearExpression Class evaluates the Year grammar
    //That is Replacing YYYY with the Year from the Input Date Property
    public class YearExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
        }
    }
}
