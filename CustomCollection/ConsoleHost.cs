using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection
{
    internal class ConsoleHost
    {
        internal void Run()
        {

            DateTime date1 = DateTime.ParseExact("29/11/2017", "dd/MM/yyyy", null);
            DateTime date2 = DateTime.ParseExact("21/03/2015", "dd/MM/yyyy", null);
            DateTime date3 = DateTime.ParseExact("13/01/2015", "dd/MM/yyyy", null);
            DateTime date4 = DateTime.ParseExact("21/11/2017", "dd/MM/yyyy", null);
            DateTime date5 = DateTime.ParseExact("13/01/2016", "dd/MM/yyyy", null);
            DateTime date6 = DateTime.ParseExact("21/01/2015", "dd/MM/yyyy", null);

            OrderedCollection<DateTime> orderedDateCollection = new OrderedCollection<DateTime>();

            Person person1 = new Person("Tom", 2);
            Person person2 = new Person("Frank", 45);
            Person person3 = new Person("Artavazd", 3);

            OrderedCollection<Person> people = new OrderedCollection<Person>();

            OrderedCollection<int> orderedIntegers = new OrderedCollection<int>();

            try
            {
                orderedDateCollection.AddMember(date1);
                orderedDateCollection.AddMember(date2);
                orderedDateCollection.AddMember(date3);
                orderedDateCollection.AddMember(date4);
                orderedDateCollection.AddMember(date5);
                orderedDateCollection.AddMember(date6);

                people.AddMember(person1);
                people.AddMember(person2);
                people.AddMember(person3);

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
                    Console.WriteLine($"{item.Name}: {item.Age}");

                Console.WriteLine("__________________________");

                foreach (var item in orderedDateCollection)
                    Console.WriteLine(item);

                Console.ReadKey();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
