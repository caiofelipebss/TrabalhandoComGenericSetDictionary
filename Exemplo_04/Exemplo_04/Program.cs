using System;
using System.Collections.Generic;

namespace Exemplo_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SortedSet: ");
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 7, 8, 11 };
            SortedSet<int> b = new SortedSet<int>() { 1, 3, 5, 6, 9, 8, 11 };

            // União
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        /*
         * HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook"));
            foreach (String p in set) {
            Console.WriteLine(p);
        */
    }
}


// Conjuntos: HashSet e SortedSet