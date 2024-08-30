using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class InheritanceAssign
    {
        static void Main() {
            AccessDemo obj = new AccessDemo();
            //Console.WriteLine(obj.name);
            C objC = new C(11,22,33);
            objC.display();
        }
    }
    class A {
        public int a;
        public A(int i)
        {
            a = i;
        }
    }
    class B : A
    {
        public int b;
        public B(int i, int j) : base(i)
        {
            b = j;
        }
        public void dis() {
            Console.WriteLine("Hello");
        }
    }
    class C:B
    {
        //a,b
        public int c;
        public C(int i, int j, int k):base(i,j)
        {
            c = k;
        }
        public void display() { 
            base.dis(); 
            Console.WriteLine(a+" "+b+" "+c);
        }
    }
}
