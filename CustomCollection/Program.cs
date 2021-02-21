using System;
using System.Collections.Generic;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<DateTime> data = new MyCollection<DateTime>();
            DateTime dt= Convert.ToDateTime("11/29/2017");
            DateTime dt2= Convert.ToDateTime("11/21/2017");
            MyCollection<int> my = new MyCollection<int>();
            Person p = new Person("hgfhjsdj", 2);
            Person p1 = new Person("agfhjsdj", 45);
            Person p2 = new Person("kfhjsdj", 3);
            MyCollection<Person> person = new MyCollection<Person>();
            try
            {
                //data.Add(dt);
                //data.Add(dt2);
                //Console.WriteLine(my.Count);
                //Console.WriteLine(my[0]);
                //person.Add(p);
                //person.Add(p1);
                //person.Add(p2);
                //Console.WriteLine(my.Count);
                //Console.WriteLine(my[0]);
                my.AddMember(845);
                my.AddMember(8);
                my.AddMember(66);
                my.AddMember(4);
                my.AddMember(2);
                my.AddMember(5);
                my.AddMember(7);
                my.AddMember(21236);
                //Console.WriteLine(my.Count);
                //Console.WriteLine(my[0]);
                foreach (var item in my)
                {
                    Console.Write($"{item} ,");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
