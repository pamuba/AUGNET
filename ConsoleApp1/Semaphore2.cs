using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Semaphore2
    {
        public static Semaphore semaphore = new Semaphore(3,3);

        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread threadObj = new Thread(DoSomeTask)
                {
                    Name = "Thread: " +i
                };
                threadObj.Start();
            }
            Console.ReadKey();
        }
        static void DoSomeTask() {
            Console.WriteLine(Thread.CurrentThread.Name+" Wants to Enter into the CS");
            try
            {
                //Blocks the current thread until the current WaitHandle receives a signal
                semaphore.WaitOne();
                Console.WriteLine("Success " + Thread.CurrentThread.Name + " Is processing the CS "+DateTime.Now.ToString("mm:ss:ffff"));
                Thread.Sleep(5000);
                Console.WriteLine(Thread.CurrentThread.Name + " Exited");
            }
            finally {
                semaphore.Release();
            }
        }
    }
}
