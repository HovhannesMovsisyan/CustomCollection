using System;
using System.Collections.Generic;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedCollection<DateTime> orderedDateCollection = new OrderedCollection<DateTime>();

            DateTime date1 = Convert.ToDateTime("29/11/2017");
            DateTime date3 = Convert.ToDateTime("21/03/2015");
            DateTime date4 = Convert.ToDateTime("13/01/2015");
            DateTime date2 = Convert.ToDateTime("21/11/2017");
            DateTime date5 = Convert.ToDateTime("13/01/2016");
            DateTime date6 = Convert.ToDateTime("21/01/2015");

            OrderedCollection<int> orderedIntegers = new OrderedCollection<int>();
            Person p = new Person("Tom", 2);
            Person p1 = new Person("Frank", 45);
            Person p2 = new Person("Artavazd", 3);
            OrderedCollection<Person> people = new OrderedCollection<Person>();
            try
            {
                orderedDateCollection.AddMember(date1);
                orderedDateCollection.AddMember(date2);
                orderedDateCollection.AddMember(date3);
                orderedDateCollection.AddMember(date4);
                orderedDateCollection.AddMember(date5);
                orderedDateCollection.AddMember(date6);

                people.AddMember(p);
                people.AddMember(p1);
                people.AddMember(p2);

                orderedIntegers.AddMember(845);
                orderedIntegers.AddMember(8);
                orderedIntegers.AddMember(66);
                orderedIntegers.AddMember(4);
                orderedIntegers.AddMember(5);
                orderedIntegers.AddMember(21236);
                orderedIntegers.AddMember(2);
                orderedIntegers.AddMember(7);

                foreach (var item in orderedIntegers)
                    Console.WriteLine(item);

                Console.WriteLine("__________________________");

                foreach (var item in people)
                    Console.WriteLine($"{item.name}: {item.age}");

                Console.WriteLine("__________________________");

                foreach (var item in orderedDateCollection)
                    Console.WriteLine(item);

                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}