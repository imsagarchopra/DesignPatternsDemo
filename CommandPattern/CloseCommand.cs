using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{  
    //ConcreteCommand C 
    //It defines a binding between a Receiver Object i.e. Document and an Action i.e. Close
    class CloseCommand : ICommand
    {
        //Reference of Receiver Object
        private Document document;
        //Initializing the Receiver Object using the Constructor
        public CloseCommand(Document doc)
        {
            document = doc;
        }
       
        public bool CanExecute()
        {
            return document.IsOpen;
        }
        //Execute Method will internally call the Receiver Object Close Method
        public void Execute()
        {
            document.Close();
        }

        public void UnExecute()
        {
            document.Open();
        }
    }
}
