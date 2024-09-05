using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


using System;

namespace ConsoleApp1
{
    public class Location1
    {
        private string locationName;
        private string dept;

        public Location1(string name, string dept) => (Name, Dept) = (name, dept);
       /* {
            locationName = name;
            this.dept = dept;
        }*/

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }

        public string Dept
        {
            get => dept;
            set => dept = value;
        }



        static void Main(string[] args)
        {
            // Create a Location1 object using the constructor
            Location1 loc = new Location1("Srinadh", "HR");

            // Display the properties
            Console.WriteLine($"Name: {loc.Name}, Dept: {loc.Dept}");

        }

    }
}



