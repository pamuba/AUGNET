using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Base Class
    class Dimensions {

        private string name;

        public virtual string Name { get => name; set => name = value; }

        public virtual double Area(int x, int y)
        {
            return x * y;
        }
    }
    class Test2:Dimensions {
        new public double Area(int x, int y)
        {
            return x * y;
        }
    }
    internal class VirtualDemo: Test2
    {
        public double Area(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            VirtualDemo ob = new VirtualDemo();
            Console.WriteLine(ob.Area(8,2));
        }
    }

}
