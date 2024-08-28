using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OutTest {
        public int GetParts(double n, out double frac) {
            int whole;
            whole = (int)n;
            frac = n - whole;
            return whole;
        }
    }
    class RefTest {
        public void Sqr(ref int a)
        {
            a = a * a;
        }
    }
    internal class RefandOut
    {
        
        static void Main(string[] args)
        {
            RefTest ob = new RefTest();
            int a = 10;
            Console.WriteLine("Before: "+ a);
            ob.Sqr(ref a);
            Console.WriteLine("After: "+ a);


            OutTest obj = new OutTest();
            int i;
            double j;
            i = obj.GetParts(10.125, out j);

            Console.WriteLine("Interger Part: "+i);
            Console.WriteLine("Fractional Part: "+j);
        }
    }
}
