using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThreadPoolStopWatch
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                MethodWithThreads();
                MethodWithThreadPool();
            }

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Using Threads");
            stopwatch.Start();  
            MethodWithThreads();
            stopwatch.Stop();   
            Console.WriteLine("Time Consumed With Threads:"+stopwatch.ElapsedMilliseconds);

            stopwatch.Restart();

            Console.WriteLine("Using ThreadPool");
            stopwatch.Start();
            MethodWithThreadPool();
            stopwatch.Stop();
            Console.WriteLine("Time Consumed With Pool:" + stopwatch.ElapsedMilliseconds);

        }
        public static void MethodWithThreads()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(test);
                thread.Start();
            }
        }
        public static void MethodWithThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(test));
            }
        }
        public static void test(object obj) { }
    }
}
