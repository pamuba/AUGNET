using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThreadsWithParams
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadsWithParams().Method1);
            th.Priority = ThreadPriority.Highest;   
            th.Start(7);
        }
        public void Method1(object Max)
        {
            Console.WriteLine("Method1 Started");
            int max = (int)Max; 
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine("Method1:" + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Method1 Ended");
        }
    }
    
}
