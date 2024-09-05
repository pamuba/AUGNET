using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Outtst
    {

        public int getparts(double d, out double frac)
        {
            int wholenum = 0;
            wholenum = (int)d;
            frac = d - wholenum;
            return wholenum;
        }

    }

    class Reftst
    {
        public void sqr(ref int i)
        {
            i = i * i;
        }
    }

    internal class RefandOut1
    {
        public void sqr(ref int i)
        {
           i = i * i; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ref Output");
            Reftst rf = new Reftst();
            int a = 10;
            Console.WriteLine("Before: " + a);
            rf.sqr(ref a);
            Console.WriteLine("After: " + a);
            Console.WriteLine("Out Output:");
            Outtst ot = new Outtst();
            int i; double j;
            i = ot.getparts(10.125, out j);
            Console.WriteLine("Whole Number: " + i + "\nFraction Part: " + j);
        }



    }
}
