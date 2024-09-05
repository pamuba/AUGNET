using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Location
    {
        static void Main(string[] args)
        {   
            
            Singleton obj1 = Singleton.GetSingletonInstance();  
            obj1.SomeMethod("First Instance");
            Singleton obj2 = Singleton.GetSingletonInstance();
            obj2.SomeMethod("Second Instance");
        }
    }
    sealed class Singleton {
        private static int counter = 0; // simple counter
        private static Singleton instance = null; //to make sure only one object is created. An object variable is created here.
        private static readonly object InstanceLock = new object(); // Lock means only one thread can only execute at a single time. These are usually static readonly. An object is created here.

        public static Singleton GetSingletonInstance() {  // This is created to be called from main from outside this sealed class and so that we can also use the private constructor.
            lock (InstanceLock) {  // Checks if there is a Instance lock object
                if (instance == null) { // Checks if there is an instance
                    instance = new Singleton(); // Calls in the constructor
                }
                return instance;   // returns the instance
            }
        }
        private Singleton() {
            counter++; // To check how many times the instance is creat`ed.
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
