using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Receiver Object 
    // The Receiver contains the business logic. 
    // They know how to perform all kinds of operations
    // They Know how to handle the Request i.e. Performing the actual Operation
    public class Document
    {
        public bool IsOpen { get; private set; }
        public void Open()
        {
            Console.WriteLine("Document Opened");
        }
        public void Save()
        {
            Console.WriteLine("Document Saved");
        }
        public void Close()
        {
            Console.WriteLine("Document Closed");
        }

        public void UnSave()
        {
            Console.WriteLine("Document UnSave");
        }
    }
}
