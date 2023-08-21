using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //ConcreteCommand B 
    //It defines a binding between a Receiver Object i.e. Document and an Action i.e. Save
    class SaveCommand : ICommand
    {
        //Reference of Receiver Object
        private Document document;
        //Initializing the Receiver Object using the Constructor
        public SaveCommand(Document doc)
        {
            document = doc;
        }
                
        public bool CanExecute()
        {
            return document.IsOpen;
        }

        //Execute Method will internally call the Receiver Object Save Method
        public void Execute()
        {
            document.Save();
        }

        public void UnExecute()
        {
            document.UnSave();
        }
    }
}
