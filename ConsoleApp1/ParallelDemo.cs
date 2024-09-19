using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ParallelDemo
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("C# For Loop");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            ///////////////////////////////////////////////////////////
            //Console.WriteLine("C# Parallel For Loop");

            ////It will start from 1 until 10
            ////Here 1 is the start index which is Inclusive
            ////Here 11 us the end index which is Exclusive
            ////Here number is similar to i of our standard for loop
            ////The value will be store in the variable number
            //Parallel.For(1, 11, number => {
            //    Console.WriteLine(number);
            //});
            //Console.ReadLine();
            ////////////////////////////////////////////////////////////
            ///Console.WriteLine("C# For Loop");
            //int number = 10;
            //for (int count = 0; count < number; count++)
            //{
            //    //Thread.CurrentThread.ManagedThreadId returns an integer that 
            //    //represents a unique identifier for the current managed thread.
            //    Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
            //    //Sleep the loop for 10 miliseconds
            //    Thread.Sleep(10);
            //}
            //Console.WriteLine();

            //Console.WriteLine("Parallel For Loop");
            //Parallel.For(0, number, count =>
            //{
            //    Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
            //    //Sleep the loop for 10 miliseconds
            //    Thread.Sleep(10);
            //});
            //Console.ReadLine();
            //////////////////////////////////////////////////////////
            ///DateTime StartDateTime = DateTime.Now;
            //Stopwatch stopWatch = new Stopwatch();

            //Console.WriteLine("For Loop Execution start");
            //stopWatch.Start();
            //for (int i = 0; i < 50; i++)
            //{
            //    long total = DoSomeIndependentTask();
            //    Console.WriteLine("{0} - {1}", i, total);
            //}
            //DateTime EndDateTime = DateTime.Now;
            //Console.WriteLine("For Loop Execution end ");
            //stopWatch.Stop();
            //Console.WriteLine($"Time Taken to Execute the For Loop in miliseconds {stopWatch.ElapsedMilliseconds}");

            //Console.ReadLine();
            //////////////////////////////////////////////////////////
            ///
            DateTime StartDateTime = DateTime.Now;
            Stopwatch stopWatch = new Stopwatch();

            Console.WriteLine("Parallel For Loop Execution start");
            stopWatch.Start();

            Parallel.For(0, 50, i => {
                long total = DoSomeIndependentTask();
                Console.WriteLine("{0} - {1}", i, total);
            });

            DateTime EndDateTime = DateTime.Now;
            Console.WriteLine("Parallel For Loop Execution end ");
            stopWatch.Stop();
            Console.WriteLine($"Time Taken to Execute Parallel For Loop in miliseconds {stopWatch.ElapsedMilliseconds}");

            Console.ReadLine();
        }
        static long DoSomeIndependentTask()
        {
            //Do Some Time Consuming Task here
            //Most Probably some calculation or DB related activity
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
