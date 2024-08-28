using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Demo {
        static readonly string dept = "Inital";
        static Demo()
        {
            
        }
        public static int MyProperty { get ; set; }
    }
    class Person{
        public static string name = "Sam";
        public int age;

        static Person() {
            name = "John";
        }
        public Person(int age)
        {
            this.age = age;
        }
        static public void display() {
            int a = 10;
            Console.WriteLine(Person.name + " " + a);
        }
        public void normal() { 
         
        }
    }
    internal class StaticDemo
    {
        static int i;
        static void Main(string[] args)
        {
            Console.WriteLine(Person.name);
            Person p1 = new Person(11);
            Console.WriteLine(Person.name+" "+p1.age);
            ////Person p2 = new Person(22);
            //Console.WriteLine(Person.name + " " + p2.age);
            ////Person p3 = new Person(33);
            //Console.WriteLine(Person.name + " " + p3.age);
            //Person p4 = new Person(44);
            ////Console.WriteLine(Person.name + " " + p4.age);
        }
    }
}
