using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SemaphoreSlimDemo
    {
        public static SemaphoreSlim semaphore = new SemaphoreSlim(initialCount:3);
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                //int count = i;
                //Thread threadObj = new Thread(() => SlimFn("Thread: " + i, i * 1000));
                ParameterizedThreadStart ps = new ParameterizedThreadStart(SlimFn);
                Thread threadObj = new Thread(ps);
                threadObj.Start("Thread: " + i);
            }
            Console.ReadKey();
        }
        static void SlimFn(object name) {
            Console.WriteLine($"{name} wants to access the CS");
            semaphore.Wait();
            Console.WriteLine($"{name} granted access to the CS");
            Thread.Sleep( 1000 );
            Console.WriteLine($"{name} Exited");
            semaphore.Release();
        }
    }
}
