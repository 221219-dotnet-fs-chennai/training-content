using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        public static Singleton GetInstances
        {
            get
            {
                if(instance==null)
                {
                    instance = new Singleton();
                    
                }
                return instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value :" + counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
