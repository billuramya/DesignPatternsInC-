using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns
{
    class SingleTonPattern
    {
        private static int counter = 0;
        public SingleTonPattern()
        {
            counter++;
            Console.WriteLine("Counter Value {0}", counter);
        }

            public void PrintDetails(string Message)
            {
                Console.WriteLine(Message);
            }
        
    }
}
