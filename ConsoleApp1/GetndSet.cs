using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The statement object obj = new Person { Name = "John", Age = 30 }; creates a new Person object with the specified properties and assigns it to a variable of type object. 
This is an example of polymorphism, where a derived type (Person) is treated as its base type (object), allowing for more flexible and generic programming. 
However, to access the specific properties of Person, you would need to cast it back to the Person type.

Implications:
Since obj is of type object, you can only access the members of the object class directly through this variable (like ToString(), GetHashCode(), etc.).
If you need to access the Person-specific members (like Name or Age), you'll have to downcast obj back to Person, like this:

    Person person = (Person)obj;
    Console.WriteLine(person.Name); // Outputs: John*/

namespace ConsoleApp1
{
    internal class GetndSet
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        static void Main(string[] args)
        {
            Object getndSet = new GetndSet {Name = "Srinadh", Age = 27 };
            Console.WriteLine(getndSet.ToString());
            Console.WriteLine(getndSet.GetType());
            
        }

    }

   

}

