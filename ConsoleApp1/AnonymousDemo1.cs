using System;

namespace ConsoleApp1
{
    delegate int CountIt(int end);
   
    internal class AnonymousDemo1
    {   
        static void Main(string[] args)
        {
            CountIt count = delegate (int end)
            {
                int sum = 0;
                for (int i = 1; i <= end; i++)
                {
                    sum += i;
                    Console.WriteLine(i);
                    

                }
                return sum;


            };

            Console.WriteLine("Sum: " + count(5)); 
        }
    }
}