using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MonitorDemo
    {
        private static readonly object lockObject = new object();

        public static void PrintNumbers() {
            Console.WriteLine(Thread.CurrentThread.Name + "Trying to Enter the CS");
            try
            {
                Monitor.Enter(lockObject);
                Console.WriteLine(Thread.CurrentThread.Name + "Entered into the CS");
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + ".");
                }
                Console.WriteLine();
            }
            finally {
                Monitor.Exit(lockObject);
                Console.WriteLine(Thread.CurrentThread.Name + "Exited the CS");
            }
        }
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(PrintNumbers) { 
                    Name = "Child Thread:"+ i.ToString(),
                };
            }
            foreach (Thread t in threads) {
                t.Start();
            }
        }
    }
}
