using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Strategy Interface
    // The IPaymentStrategy Interface declares the method Pay that is common to all supported versions of the algorithm.
    // The Context is going to use this IPaymentStrategy Interface to call the algorithm defined by Concrete Strategies.
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}
