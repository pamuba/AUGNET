using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void CountIt(int end);
    internal class AnonymousDemo
    {
        static void Main(string[] args)
        {
            CountIt count = delegate(int end)
            {
                for (int i = 1; i <= end; i++)
                {
                    Console.WriteLine(i);
                }
            };

            count(5);
        }
    }
}
