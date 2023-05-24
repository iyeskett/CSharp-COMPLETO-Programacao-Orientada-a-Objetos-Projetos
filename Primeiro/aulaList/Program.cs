using System;
using System.Collections.Generic;

namespace aulaList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Joao");
            list.Add("Muttley");
            list.Add("Boo");
            list.Insert(2, "Peep");



            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine("First 'M': " + s1);

            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("Last 'M': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine("First position 'M': "+pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("First position 'M': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 4);
            Console.WriteLine("-----------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Boo");
            Console.WriteLine("-----------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
