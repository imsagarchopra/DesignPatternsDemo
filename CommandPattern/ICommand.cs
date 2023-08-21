using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface ICommand
    {
        // Command Interface
        // It declares a method for executing a command
        void Execute();
        bool CanExecute();
        void UnExecute();
    }
}
