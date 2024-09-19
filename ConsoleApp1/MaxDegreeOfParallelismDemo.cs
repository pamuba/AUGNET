using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MaxDegreeOfParallelismDemo
    {
        static void Main(string[] args)
        {
            //Limiting the maximum degree of parallelism to 2
            //var options = new ParallelOptions()
            //{
            //    MaxDegreeOfParallelism = 2
            //};
            //int n = 10;
            //Parallel.For(0, n, options, i =>
            //{
            //    Console.WriteLine(@"value of i = {0}, thread = {1}",
            //    i, Thread.CurrentThread.ManagedThreadId);
            //    Thread.Sleep(10);
            //});
            //Console.WriteLine("Press any key to exist");
            //Console.ReadLine();
            ////////////////////////////////////////////////////////////
            var BreakSource = Enumerable.Range(0, 1000).ToList();
            int BreakData = 0;
            Console.WriteLine("Using loopstate Break Method");
            Parallel.For(0, BreakSource.Count, (i, BreakLoopState) =>
            {
                BreakData = i;
                if (BreakData == 3)
                {
                    BreakLoopState.Break();
                    Console.WriteLine("Break called iteration {0}. data = {1} ", i, BreakData);
                }
                //Console.WriteLine("***"+i);
            });
            Console.WriteLine("Break called data = {0} ", BreakData);

            var StopSource = Enumerable.Range(0, 1000).ToList();
            int StopData = 0;
            Console.WriteLine("Using loopstate Stop Method");
            Parallel.For(0, StopSource.Count, (i, StopLoopState) =>
            {
                StopData = i;
                if (StopData == 3)
                {
                    StopLoopState.Stop();
                    Console.WriteLine("Stop called iteration {0}. data = {1} ", i, StopData);
                }
                //Console.WriteLine("***"+ i);
            });

            Console.WriteLine("Stop called data = {0} ", StopData);
            Console.ReadKey();
        }
    }
}
//stop all the iterations ASAP
//break complete all the iterations on all the parallel threads before the current ireration
