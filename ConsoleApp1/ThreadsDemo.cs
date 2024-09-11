using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThreadsDemo
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Started";

            #region
            //Thread t1 = new Thread(() => {
            //    Console.WriteLine("Lambda Started");
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("Lambda:" + i);
            //        Thread.Sleep(1000);
            //    }
            //    Console.WriteLine("Lambda Ended");
            //});
            //t1.Start();

            //Thread t1 = new Thread(delegate ()
            //{
            //    Console.WriteLine("Anon Started");
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("Anon:" + i);
            //        Thread.Sleep(1000);
            //    }
            //    Console.WriteLine("Anon Ended");

            //});

            //t1.Start();

            //Console.WriteLine(t.Name);
            ////Method1();
            ////Method2();
            ////Method3();

            //Thread t1 = new Thread(Method1)
            //{
            //    Name = "Thread1"
            //};
            //Thread t2 = new Thread(Method2)
            //{
            //    Name = "Thread2"
            //};
            //Thread t3 = new Thread(Method3)
            //{
            //    Name = "Thread3"
            //};

            //t1.Start();
            //t1.Join();  
            //t2.Start();
            //t2.Join();
            //t3.Start();
            //Thread.Sleep(2000);
            //t3.Abort();
            //t3.Join();
            #endregion

            ParameterizedThreadStart ts = new ParameterizedThreadStart(Method1);
            ts += Method2;
            //ts += Method3;

            Thread t1 = new Thread(ts);
            t1.Start(2);

            Console.WriteLine("Main Ended");
        }
        static void Method1(object Max) {
            Console.WriteLine("Method1 Started");
            int max = (int)Max;
            for (int i = 0; i <=max; i++)
            {
                Console.WriteLine("Method1:"+i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Method1 Ended");
        }
        static void Method2(object Max)
        {
            Console.WriteLine("Method2 Started");
            int max = (int)Max;
            for (int i = 0; i <=max; i++)
            {
                Console.WriteLine("Method2:" + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Method2 Ended");
        }
        static void Method3()
        {
            Console.WriteLine("Method3 Started");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method3:" + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Method3 Ended");
        }
    }
}
//StackAlloc