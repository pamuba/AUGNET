using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LambdaDemo
    {
        delegate int Incr(int i);
        delegate bool IsEven(int v);
        delegate bool IsRange(int low, int high, int val);
        delegate int IntOp(int end);
        static void Main(string[] args)
        {
            #region
            Incr incr = count => count + 2; 

            //(param list)=>expr
            int x = -10;
            while (x <= 0) {
                x = incr(x);
            }

            IsEven even = n => n % 2 == 0;
            

            for (int i = 0; i < 10; i++) {
                if (even(i)) {
                    Console.WriteLine(i);
                }
            }
            //isRange range = (high, low, val) => low <= val <= high ? true : false
            IsRange range = (low, high, val) => val >= low && val <= high;

            if (range(1, 5, 3))
            {
                Console.WriteLine("3 is in range");
            }

            #endregion

            IntOp fact = n => {
                int r = 1;
                for (int i = 1; i <= n; i++)
                {
                    r = i * r;
                }
                return r;
            };
            Console.WriteLine("Fatorial of 5:"+ fact(5));

        }
    }
}
