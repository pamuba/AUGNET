using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate string StrMod(string str);
    internal class DelegateDemo
    {
        static string ReplaceSpaces(string s) {
            Console.WriteLine("Replacing With Hyphens:");
            return s.Replace(' ', '-');
        }
        static string RemoveSpaces(string s)
        {
            Console.WriteLine("Removing Spaces:");
            return s.Replace(' ',Char.MinValue);
        }
        static string ReverseSpaces(string s)
        {
            Console.WriteLine("ReversingThe String:");
            char[] data = s.ToCharArray();
            IEnumerable<char> val = data.Reverse();
            //Array.Reverse(data);

            //String reverse_new = new String(data);

            //string[] words = reverse_new.Split(' ');
            //Array.Reverse(words);
            ////cat dog puppy
            ////puppy dog cat
            //string answer = string.Join(" ", words);

            //return answer;

            StringBuilder result = new StringBuilder(data.Length);

            foreach (char c in val)
            {
                result.Append(c);
            }
            return result.ToString();

        }

        static void Main(string[] args)
        {
            //StrMod del = new StrMod(ReplaceSpaces);
            //Console.WriteLine(del("This is a test string"));

            //del = new StrMod(RemoveSpaces);
            //Console.WriteLine(del("This is a test string"));

            //del = new StrMod(ReverseSpaces);
            //Console.WriteLine(del("This is a test string"));

            StrMod del = new StrMod(ReplaceSpaces);
            del += RemoveSpaces;
            del += ReverseSpaces;

            del -= ReverseSpaces;
            del += ReverseSpaces;

            //Console.WriteLine(del("This is a test string"));

            //Delegate[] arr = del.GetInvocationList();

            foreach (Delegate d in del.GetInvocationList()) {
                Console.WriteLine(d.Method.Name.ToString());
            }
        }
    }
}
