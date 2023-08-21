using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    //This is going to be a Concrete class that implements the Expression Interface.
    //The following Concrete MonthExpression Class evaluates the Month grammar
    //That is Replacing MM with the Month from the Input Date Property
    public class MonthExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }
}
