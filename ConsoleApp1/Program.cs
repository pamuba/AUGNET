using System;
using System.Diagnostics;

namespace MyApp
{
    class Person {
        public int id;
        public string FistName;
        public string LastName;

        public override string ToString()
        {
            return this.FistName+" "+this.LastName;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //var names = new string[] { "each" ,"element","explicitly"};
            //Array.Sort(names);
            //Array.Reverse(names);
            //string newval = string.Join(",\n", names);
            //Console.WriteLine(newval);
        }
    }
}



