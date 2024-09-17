using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThreadPoolDemo
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 200; i++)
            {
                ThreadPool.SetMinThreads(1,2);
                ThreadPool.SetMaxThreads(2,1);  
                ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
                Console.WriteLine(ThreadPool.ThreadCount);
            }
            Console.ReadLine();


            //for (int i = 0; i < 10; i++) {
            //    Thread thread = new Thread(MyMethod)
            //    {
            //        Name = "Thread: " +i
            //    };
            //    thread.Start();
            //}
        }
        public static void MyMethod(object obj) {
            Thread thread = Thread.CurrentThread;
            string message = $"Background:{thread.IsBackground}. Thread Pool:{thread.IsThreadPoolThread}," +
                $"Thread ID:{thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
}
