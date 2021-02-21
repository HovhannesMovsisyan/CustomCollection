using System;
using System.Collections.Generic;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> my = new MyCollection<int>();
            //my.Add(8);
            //my.Add(66);
            //my.Add(4);
            //my.Add(2);
            //my.Add(5);
            //my.Add(7);
            //my.Add(21236);
            DateTime dt= Convert.ToDateTime("11/29/2017");
            DateTime dt2= Convert.ToDateTime("11/21/2017");
            //MyCollection<DateTime> my = new MyCollection<DateTime>();
            Person p = new Person("hgfhjsdj", 2);
            Person p1 = new Person("agfhjsdj", 45);
            Person p2 = new Person("kfhjsdj", 3);
            MyCollection<Person> person = new MyCollection<Person>();
            try
            {
                //my.Add(dt);
                //my.Add(dt2);
                //Console.WriteLine(my.Count);
                //Console.WriteLine(my[0]);
                person.Add(p);
                person.Add(p1);
                person.Add(p2);
                Console.WriteLine(my.Count);
                Console.WriteLine(my[0]);
                my.Add(8);
                my.Add(66);
                my.Add(4);
                my.Add(2);
                my.Add(5);
                my.Add(7);
                my.Add(21236);
                Console.WriteLine(my.Count);
                Console.WriteLine(my[0]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
