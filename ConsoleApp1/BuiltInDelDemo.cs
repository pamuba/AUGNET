using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BuiltInDelDemo
    {
        static void Main(string[] args)
        {
            //Func<int, float, double, double> obj = new Func<int, float, double, double>(AddNumber1);
            //double result = obj.Invoke(100, 125.23f, 456.678);
            //Console.WriteLine(result);

            Func<int, float, double, double> obj = (x, y, z) =>
            {
                return x+ y + z;
            };
            double result = obj.Invoke(100, 125.23f, 456.678);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            obj2.Invoke(100, 125.23f, 456.678);

            Predicate<string> obj3 = (name) =>
            {
               return name.Length > 5 ? true: false;
            };

            bool results = obj3.Invoke("John Dyke");
            Console.WriteLine(results);
        }

        private static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }

        private static double AddNumber1(int arg1, float arg2, double arg3)
        {
            return arg1 + arg2 + arg3;
        }
        private static void AddNumber2(int arg1, float arg2, double arg3)
        {
            Console.WriteLine(arg1 + arg2 + arg3);
        }
    }
}
