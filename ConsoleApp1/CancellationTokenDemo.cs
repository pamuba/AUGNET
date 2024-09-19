using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CancellationTokenDemo
    {
        static void Main(string[] args)
        {
            SomeMethod();
            Console.ReadKey();
        }
        public static async void SomeMethod() {
            int count = 10;
            Console.WriteLine("SomeMethod Started");
            CancellationTokenSource cancellationTokenSource = 
                new CancellationTokenSource();
            cancellationTokenSource.CancelAfter(5000);

            try
            {
                await LongRunningTask(count, cancellationTokenSource.Token);
            }
            catch (TaskCanceledException ex) {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("SomeMethod Ended");
        }
        public static async Task LongRunningTask(int count, CancellationToken token) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("LongRunningTask Started");
            for (int i = 0; i <= count; i++) { 
                await Task.Delay(1000);
                Console.WriteLine("LongRunningTask Processing......");
                if (token.IsCancellationRequested) { 
                    throw new TaskCanceledException();  
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"LongRunningTask took {stopwatch.ElapsedMilliseconds / 1000.0} Seconds");
        }
    }
}
