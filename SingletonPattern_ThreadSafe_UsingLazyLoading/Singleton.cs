using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern_ThreadSafe_UsingLazyLoading
{
    public sealed class Singleton
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;
        //This will make the Singleton Instance Lazy Loading
        //Lazy Object are Thread-Safe by default
        private static readonly Lazy<Singleton> SingleInstance = new Lazy<Singleton>(() => new Singleton());
        //The following Static Method is going to return the Singleton Instance
        //This is Thread-Safe as it uses Lazy<T> Object
        public static Singleton GetInstance()
        {
            //Now we don't need to use any NULL Checking code
            //We don't need to write Explicit code for thread-safety
            //Call the Value property of the Lazy object which will return the Singleton Instance
            return SingleInstance.Value;
        }
        private Singleton()
        {
            //Each Time the Constructor is called, increment the Counter value by 1
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
        //The following method can be accessed from outside of the class by using the Singleton Instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
