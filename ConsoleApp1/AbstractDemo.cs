using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IA
    {
        void M();
    }
    interface IB 
    {
        void M();
    }
    interface IC : IA, IB
    {
        void IB.M() { Console.WriteLine("IC.IB.M"); }
        void IA.M() { Console.WriteLine("IA.IB.M"); }
    }
    interface ISampleInterface
    {
        void extraFunction() { 
            
        }
        void extraFunction1()
        {

        }
        void extraFunction2()
        {

        }
        void SampleMethod();
        void AddMethod();
        void SubtractMethod();
    }
    abstract class Abs {
        abstract public void display();
        public void fn1() {
            Console.WriteLine("fn1");
        }
        public void fn2() {
            Console.WriteLine("fn1");
        }
    }

    class Child3 : Abs {
        sealed public override void display()
        {
            Console.WriteLine("display");
        }
    }
    class Child4 : Child3
    {
        //public override void display()
        //{
        //    Console.WriteLine("display overriden again");
        //}
    }
    internal class AbstractDemo: ISampleInterface, IC
    {
        static void Main(string[] args)
        {
            AbstractDemo obj = new AbstractDemo();
            
            
        }

        public void AddMethod()
        {
            
        }

        public void SampleMethod()
        {
            
        }

        public void SubtractMethod()
        {
            
        }
    }
}
