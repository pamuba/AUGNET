using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WaitPulse
    {
        const int numberLimit = 20;
        private static readonly object lockPrintNumbres = new object();

        public static void PrintEvenNumbers()
        {
            try
            {
                Monitor.Enter(lockPrintNumbres);
                for (int i = 0; i <= numberLimit; i=i+2)
                {
                    Console.Write(i + " ");
                    Monitor.Pulse(lockPrintNumbres);


                    bool isLast = false;
                    if (i == numberLimit) { 
                        isLast = true;
                    }
                    if (!isLast) { 
                        Monitor.Wait(lockPrintNumbres);
                    }
                }
            }
            finally
            {
                Monitor.Exit(lockPrintNumbres);
            }
        }

        public static void PrintOddNumbers()
        {
            try
            {
                Monitor.Enter(lockPrintNumbres);
                for (int i = 1; i <= numberLimit; i = i + 2)
                {
                    Console.Write(i + " ");
                    Monitor.Pulse(lockPrintNumbres);


                    bool isLast = false;
                    if (i == numberLimit -1 )
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        Monitor.Wait(lockPrintNumbres);
                    }
                }
            }
            finally
            {
                Monitor.Exit(lockPrintNumbres);
            }
        }


        static void Main(string[] args)
        {
            Thread evenTh = new Thread(PrintEvenNumbers);
            Thread oddTh = new Thread(PrintOddNumbers);

            evenTh.Start();
            Thread.Sleep(100);
            oddTh.Start();

            evenTh.Join();
            oddTh.Join();

        }
    }
}
