using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AutoResetDemo
    {
        static ManualResetEvent autoResetEvent = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread th = new Thread(SomeMethod);
                th.Start();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.ReadLine();
                autoResetEvent.Set();
                //autoResetEvent.Set();
            }
            //implement Reset()

            //Thread th = new Thread(SomeMethod);
            //th.Start();
            //Thread.Sleep(2000);
            //autoResetEvent.Set();
            //autoResetEvent.Set();
        }
        static void SomeMethod() {
            Console.WriteLine("Starting........");
            autoResetEvent.WaitOne();
            Console.WriteLine();
            autoResetEvent.WaitOne();
            Console.WriteLine("Finishing1..........");
        }
    }
}
