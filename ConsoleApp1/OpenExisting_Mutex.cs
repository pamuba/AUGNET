using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OpenExisting_Mutex
    {
        static Mutex _mutex;
        static void Main(string[] args)
        {
            if (!IsSingleInstance())
            {
                Console.WriteLine("More than one instance");
            }
            else {
                Console.WriteLine("One Instance");
            }
            Console.ReadLine();
        }
        static bool IsSingleInstance()
        {
            try
            {
                Mutex.OpenExisting("MyMutex");
            }
            catch {
                _mutex = new Mutex(true, "MyMutex");
                return true;
            }
            return false;
        }
    }
}
