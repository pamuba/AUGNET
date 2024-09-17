using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class async_await
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");
            SomeMethod();
            Console.WriteLine("Main Method Ended");
            Console.ReadLine();
        }
        public async static void SomeMethod() {
            Console.WriteLine("Some Method Started .........");
            await Wait();
            Console.WriteLine("Some Method Ended");

        }
        public async static Task Wait() {
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("3 seconds Executed");
        }
    }
}

//Task or Task<T>
//ValueTask or ValueTask<T>
