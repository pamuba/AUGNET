using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExtensionDemo
    {
        static void Main(string[] args)
        {
            int i = 10;

            bool result = i.IsGreaterThan("100");

            Console.WriteLine(result);

            string name = "J a m e s";
            Console.WriteLine(name.ReplaceEXT());
        }
    }
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, string value)
        {
            return i > Convert.ToInt32(value);
        }
        public static string ReplaceEXT(this string a) {
            return a.Replace(" ", "*");
        }

    }
}
