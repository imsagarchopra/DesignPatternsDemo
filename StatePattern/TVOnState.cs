using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TVOnState : ITVState
    {
        public void TurnOff()
        {
            Console.WriteLine("TV is successfully turned OFF.");
        }

        public void TurnOn()
        {
            Console.WriteLine("TV is already turned ON.Nothing to do.");
        }
    }
}
