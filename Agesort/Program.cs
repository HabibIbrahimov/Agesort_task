using System;
using System.Collections.Generic;

namespace Agesort
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons p1 = new Persons("Habib","Ibrahimov",25);
            Persons p2 = new Persons("Rasul","Abbasov",13);
            Persons p3 = new Persons("Hesen","Hesenli",23);
            Persons p4 = new Persons("Ulvi","Memmedov",18);
            List<Persons> list = new List<Persons>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Sort();
            
            foreach (Persons p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
