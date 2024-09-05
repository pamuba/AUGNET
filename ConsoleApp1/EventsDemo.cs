using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void MyEventHandler();

    class MyEvent { 
        public event MyEventHandler SomeEvent;

        //fn to raise the event
        public void OnClickEvent() {
            if (SomeEvent != null) {
                SomeEvent();
            }
        }
    }
    internal class EventsDemo
    {
        static void Handler() {
            Console.WriteLine("Enter Key Pressed Event Occured");
        }

        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            
            //add the handler to the event list
            evt.SomeEvent += Handler;

            Console.ReadLine();
            //raise the event
            evt.OnClickEvent();
        }
    }
}
