using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TVOffState : ITVState
    {
        public void TurnOff()
        {
            Console.WriteLine("TV is already turned OFF.Nothing to do.");
        }

        public void TurnOn()
        {
            Console.WriteLine("TV is successfully turned ON.");
        }
    }
}
