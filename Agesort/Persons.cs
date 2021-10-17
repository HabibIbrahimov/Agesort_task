using System;
using System.Collections.Generic;
using System.Text;

namespace Agesort
{
    class Persons: IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Persons(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            int result = 1;
            if (obj != null && obj is Persons)
            {
                Persons person = (Persons)obj;
                result = this.Age.CompareTo(person.Age);
            }
            return result;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", this.Name, this.Age);
        }
    }
}
