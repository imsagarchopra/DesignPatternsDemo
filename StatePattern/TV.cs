using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TV
    {
        public ITVState CurrentState;
        public TV(ITVState currentState)
        {
            this.CurrentState = currentState;
        }

        public void TurnONTV()
        {
            this.CurrentState.TurnOn();

            if (this.CurrentState is TVOffState)
            {
                this.CurrentState = new TVOnState();
                Console.WriteLine($"Internal State has changed to {this.CurrentState}");
            }
        }

        public void TurnOffTV()
        {
            this.CurrentState.TurnOff();

            if (this.CurrentState is TVOnState)
            {
                this.CurrentState = new TVOffState();
                Console.WriteLine($"State has changed to {this.CurrentState}");
            }
        }
    }
}
