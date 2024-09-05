using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate int CountIt(int end);
    internal class AnonymousDemo
    {
        static void Main(string[] args)
        {
            CountIt count = delegate(int end)
            {
                int sum = 0;
                for (int i = 1; i <= end; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum;
            };

            Console.WriteLine("SUM:"+count(5));
        }
    }
}
