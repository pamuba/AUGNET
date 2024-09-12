using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SemaphoreDemo
    {
        public static Semaphore semaphore = null;
        static void Main(string[] args)
        {
            try {
                semaphore = Semaphore.OpenExisting("SemaphoreDemo");
            }catch(Exception ex) {
                semaphore = new Semaphore(2,2, "SemaphoreDemo");
            }
            Console.WriteLine("External Thread trying to Acquire");
            semaphore.WaitOne();
            Console.WriteLine("External Thread Acquired");
            Console.ReadKey();
            semaphore.Release();
        }

    }
}
