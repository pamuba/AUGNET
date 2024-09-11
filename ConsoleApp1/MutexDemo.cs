using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MutexDemo
    {
        private static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 3; i++)
            {
                Thread th = new Thread(MutexDemoFn) { 
                    Name = "Child Thread:" + i
                };
                th.Start();
            }

            //using (Mutex mutex = new Mutex(false, "MutexDemo")) {


            //    if (!mutex.WaitOne(5000, false)) {
            //        Console.WriteLine("An instance of the Application is Already running");
            //        Console.ReadKey();
            //        return;
            //    }

            //    Console.WriteLine("Application is running");
            //    Console.ReadKey();
            //}
        }
        static void MutexDemoFn() {
            Console.WriteLine(Thread.CurrentThread.Name+" Wants to Enter the CS");
           
            Console.WriteLine("Success:" + Thread.CurrentThread.Name + " Wants to enter the CS");
            //Blocks the current thread until the current WaitOne method receives a signal
            //Wait until it is safe to enter 
            if (mutex.WaitOne(1000))
            {
                try
                {
                    Console.WriteLine("Success:" + Thread.CurrentThread.Name + " is processing");
                    Thread.Sleep(2000);
                    Console.WriteLine("Exit:" + Thread.CurrentThread.Name + " has completed");
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
            else { 
                Console.WriteLine("Success:" + Thread.CurrentThread.Name + " Will not acquire the mutex");
            }
           

        }
        ~MutexDemo()
        {
            mutex.Dispose();
        }
    }
}
