using System;
using System.Diagnostics;
using System.Text;

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
            //
            //StringBuilder sb = new StringBuilder("A",4);
            //Console.WriteLine(sb.Capacity);
            //sb.Append("AAAAAAAAAAAAAAAAAA");
            //Console.WriteLine(sb.Capacity);

            String[] fruits = { "Apple", "Orange", "Orange", "Apple", "Apple", "Grapes" };
            List<string> seen = new List<string>();
            for (int i = 0; i < fruits.Length; i++)
            {
                int count = 0;
                for (int j = i; j < fruits.Length; j++)
                {
                    if (fruits[i] == fruits[j])
                    {
                        count++;
                    }

                }
                if (!seen.Contains(fruits[i]))
                {
                    Console.WriteLine(fruits[i] + " : " + count);
                    seen.Add(fruits[i]);
                }
            }

            //var names = new string[] { "each" ,"element","explicitly"};
            //Array.Sort(names);
            //Array.Reverse(names);
            //string newval = string.Join(",\n", names);
            //Console.WriteLine(newval);
        }
    }
}



