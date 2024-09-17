using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ManualResetQuestion
    {
        static ManualResetEvent mre = new ManualResetEvent(true);
        static void Main(string[] args)
        {
            new Thread(Write).Start();

            for (int i = 0; i < 5; i++)
            {
                new Thread(Read).Start();
            }
        }
        //1 thread
        public static void Write() {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writing....");
            mre.Reset();
            Thread.Sleep(5000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing Completed");
            mre.Set();
        }

        //5 threads
        public static void Read() {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Reading ....");
            mre.WaitOne();
            Thread.Sleep(2000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Reading Completed");
        }
    }
}
