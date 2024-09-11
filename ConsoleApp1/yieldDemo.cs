using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class yieldDemo
    {
        static void Main(string[] args)
        {
            //foreach (int i in ProduceEvenNumbers(9))
            //{
            //    Console.Write(i);
            //    Console.Write(" ");
            //}
            //// Output: 0 2 4 6 8

            //IEnumerable<int> ProduceEvenNumbers(int upto)
            //{
            //    for (int i = 0; i <= upto; i += 2)
            //    {
            //        yield return i;
            //    }
            //}


            Console.WriteLine(string.Join(" ", TakeWhilePositive(new int[] { 2, 3, 4, 5, -1, 3, 4 })));
            // Output: 2 3 4 5

            Console.WriteLine(string.Join(" ", TakeWhilePositive(new int[] { 9, 8, 7 })));
            // Output: 9 8 7

            //it allows the method to return a sequence of integers that
            ////can be iterated over  without generating the entire sequence at once. 
            IEnumerable<int> TakeWhilePositive(IEnumerable<int> numbers)
            {
                foreach (int n in numbers)
                {
                    if (n > 0)
                    {
                        yield return n;
                    }
                    else
                    {
                        yield break;
                    }
                }
            }
        }
    }
}
