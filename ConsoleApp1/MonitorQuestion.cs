using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MonitorQuestion
    {
        private static readonly object lockObject = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Dowork).Start();
            }
            Console.ReadKey();
        }
        public static void Dowork() {
            try
            {
                Monitor.Enter(lockObject);
                if (Thread.CurrentThread.ManagedThreadId == 8)
                    throw new Exception("Thread Excp");

                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starting");
                Thread.Sleep(2000);
                //Thread.CurrentThread.Interrupt();
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} ending");
            }
            catch(Exception ex) { 
                
            }
            finally
            {
                Monitor.Exit(lockObject);
            }
        }
    }
}
