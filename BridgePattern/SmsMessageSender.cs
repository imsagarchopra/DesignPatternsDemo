using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    // This is going to be a class that implements the Implementor Interface i.e. IMessageSender
    // It also provides the implementation details for the associated Abstraction class 
    // Each Concrete Implementation corresponds to a specific platform, in this case sending messages using SMS
    public class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            //Send a message using SMS
            Console.WriteLine("'" + Message + "'   : This Message has been sent using SMS");
        }
    }
}
