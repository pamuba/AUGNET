using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Location
    {
        static int num;
        private Location() {
            num = 99;
            Console.WriteLine(num);
        }
        private Location(string msg)
        {

        }
        static void Main(string[] args)
        {
            Singleton obj1 = Singleton.GetSingletonInstance();
            obj1.SomeMethod("First Instance");
            Singleton obj2 = Singleton.GetSingletonInstance();
            obj2.SomeMethod("Second Instance");
        }
    }
    sealed class Singleton {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object InstanceLock = new object();

        public static Singleton GetSingletonInstance() {
            lock (InstanceLock) {
                if (instance == null) {
                    instance = new Singleton();
                }
                return instance;   
            }
        }
        private Singleton() {
            counter++;
            Console.WriteLine($"Singleton ctr invoked {counter} times");
        }
        public void SomeMethod(string Message) {
            Console.WriteLine($"Some Method called {Message}");
        }
        ~Singleton() {
            
        }
    }
}

//Singleton Pattern
