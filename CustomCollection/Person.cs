using System;

namespace CustomCollection
{
    public class Person : IComparable
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(object obj)
        {
            if (obj is Person otherPerson)
                return age - otherPerson.age;

            return -1;
        }
    }
}