using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class ProtectedDemo
    {
        protected string name = "John";
        public void Sum(int i, int j)
        {
            Console.WriteLine("Inherited Fn");
        }
        public void Sum(int i, float j)
        {

        }
        public void Sum(float i, int j)
        {

        }
        public void Sum(float i, int j, int k)
        {

        }
        public void Sum(int i, float j, int k)
        {

        }
        //
    }
    class Test: ProtectedDemo
    {
        public void Sum(int i, int j)
        {
            base.Sum(i, j);
            //Console.WriteLine("Own Fn");
        }
        static void Main() {

            Test ob = new Test();
            ob.Sum(1,2);
        }
    }

   

}
