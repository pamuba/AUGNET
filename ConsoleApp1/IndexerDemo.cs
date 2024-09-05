using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Person1 {
        public Person1(string name, string dept)
        {
            Name = name;
            Dept = dept;
        }
        public string Name { get; set; }
        public string  Dept{ get; set; }
    }
    class IndexerClass {
        Person1[] a;
        public int Length;
        public bool ErrFlag;

        public IndexerClass(int size)
        {
            a = new Person1[size];
            Length = size;
        }
        public Person1 this[int index] {
            get {
                if (ok(index))
                {
                    return a[index];
                }
                else {
                    ErrFlag = false;
                    return null;
                }
            }
            set
            {
                if (ok(index))
                {
                    a[index] = value;
                    ErrFlag = false;
                }
                else ErrFlag = true;
            }
        }
        private bool ok(int index) {
            if (index >= 0 & index < Length) return true;
            return false;
        }

    }
    internal class IndexerDemo
    {
        static void Main(string[] args)
        {
            IndexerClass ob = new IndexerClass(5);

            for (int i = 0; i < ob.Length; i++)
            {
                ob[i] = new Person1("name:"+i, "dept:"+i);               
            }
            Console.WriteLine(ob[1].Name+" " + ob[1].Dept);
        }

    }
}
