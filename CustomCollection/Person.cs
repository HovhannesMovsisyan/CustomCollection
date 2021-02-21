using System;

namespace CustomCollection
{
    public class Person : IComparable
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object otherObject)
        {
            if (otherObject is Person otherPerson)
                return Age - otherPerson.Age;

            return -1;
        }
    }
}