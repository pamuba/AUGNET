using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    public static class test {
        public static int addStatic(this Person x, Person? y) {

            return new ReverserClass().getFn(x, y);
        }
    }
    public class ReverserClass : IComparer<Person>
    {
        public int getFn(Person ? x, Person? y) {
            return Compare(x,y);
        }
        public int Compare(Person? x, Person? y)
        {
            return y.firstName.CompareTo(x.firstName);
            
        }
    }
    public class Person:IComparable<Person>
    {
        public Person(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }

        public string firstName;
        public string lastName;

        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (other != null)
            {
                return this.firstName.CompareTo(other.firstName);
            }
            else
                throw new ArgumentException("Object is not a Person");
        }
    }

    // Collection of Person objects. This class
    // implements IEnumerable so that it can be used
    // with ForEach syntax.
    public class People : IEnumerable
    {
        private Person[] _people;
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class PeopleEnum : IEnumerator
    {
        public Person[] _people;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public PeopleEnum(Person[] list)
        {
            _people = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    class App
    {
        static void Main()
        {
            Person[] peopleArray = new Person[4]
            {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Adam", "Johnson"),
            new Person("Sue", "Rabon"),
            };

            Array.Sort(peopleArray, new ReverserClass());

            People peopleList = new People(peopleArray);

            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);


            var p1 = new Person("John", "Smith");
            var p2 = new Person("Sam", "Smith");
            Console.WriteLine(p1.CompareTo(p2));

            var comp = new ReverserClass();
            comp.Compare(p1, p2);

            Console.WriteLine(p1.addStatic(p2));

        }
    }

    
}
