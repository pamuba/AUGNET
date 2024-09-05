using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person1 {
        public Person1(string name, string dept)
        {
            Name = name;
            Dept = dept;
        }
        public string Name { get; set; }
        public string  Dept{ get; set; }
    }
    class IndexerClass {
        Person1[] a; //array of Person1 which takes input of Name and Dept from Main function
        public int Length;
        public bool ErrFlag;

        public IndexerClass(int size) //IndexerClass constructor
        {
            a = new Person1[size];
            Length = size;
        }
        public Person1 this[int index] { //Indexer of object of person type
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
        private bool ok(int index) { //ok function to check if index passed on to Indexer is ok
            if (index >= 0 & index < Length) return true;
            return false;
        }

    }
    internal class IndexerDemo
    {
        static void Main(string[] args)
        {
            IndexerClass ob = new IndexerClass(10);

            for (int i = 0; i < ob.Length; i++)
            {
                ob[i] = new Person1("name:"+i, "dept:"+i);
                //Console.WriteLine(ob[i].Name + " " + ob[i].Dept);
            }
            Console.WriteLine(ob[1].Name+" " + ob[1].Dept);
        }

    }
}
