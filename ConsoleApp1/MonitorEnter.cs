using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MonitorEnter
    {
        private static readonly object lockPrintNumbres = new object();
        static bool IsLockTaken = false;
        public static void PrintNumbers() {
            Console.WriteLine(Thread.CurrentThread.Name+" Trying to enter into the CS");
            IsLockTaken = false;
            try
            {

                Monitor.Enter(lockPrintNumbres, ref IsLockTaken);
                Console.WriteLine(IsLockTaken);
                if (IsLockTaken)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " Entered into the CS");
                    for (int i = 0; i <= 5; i++)
                    {
                        Thread.Sleep(30);
                        Console.Write(i + ".");
                    }
                    Console.WriteLine();
                }
            }
            finally {
                if (IsLockTaken) {
                    Monitor.Exit(lockPrintNumbres);
                    Console.WriteLine(Thread.CurrentThread.Name + " Exited the CS");
                }
            }
        }
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(PrintNumbers)
                {
                    Name = "Child Thread:" +i
                };
            }
            //foreach (Thread t in threads) {
            //    t.Start();
            //}
            threads[0].Start();

            threads[0].Join();

            if (!IsLockTaken) {
                Console.WriteLine(IsLockTaken);
                Console.WriteLine("Start Next TH");
            }

           
        }
    }
}
