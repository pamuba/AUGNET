using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThreadSync
    {
        static object lockObject = new object();
        static void Main(string[] args)
        {
            Thread th1 = new Thread(SomeMethod) { 
                Name = "Thread1"
            };
            Thread th2 = new Thread(SomeMethod)
            {
                Name = "Thread2"
            };
            Thread th3 = new Thread(SomeMethod)
            {
                Name = "Thread3"
            };

            th1.Start("Thread1"); 
            th2.Start("Thread2"); 
            th3.Start("Thread3");

            

        }
        public static void SomeMethod(object name) {
            lock (lockObject) {
                Console.WriteLine("SomeMethod Starts:" + name);
                Thread.Sleep(1000);
                Console.WriteLine("SomeMethod Ends:" + name);
            }
        }
    }
}
