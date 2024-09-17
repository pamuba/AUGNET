using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AutoResetQuestion
    {
        static AutoResetEvent mre = new AutoResetEvent(true);
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }
            Thread.Sleep(3000);
            mre.Set();
        }
        public static void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Entering....");
            mre.WaitOne();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing....");
            Thread.Sleep(5000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing Completed");
            mre.Set();
        }
    }
}
