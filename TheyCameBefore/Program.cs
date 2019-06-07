using System;
using System.Collections;
using System.Collections.Generic;

namespace TheyCameBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] conjunto = {1, 2, 5, -6, 45, 3, -8, 3};

            int test = 5;

            foreach (int x in GetBeforeThan<int>(conjunto, test))
                Console.WriteLine(x);

            Console.ReadKey();
        }

        private static IEnumerable<E> GetBeforeThan<E> (IEnumerable<E> someEnumerable, E x) where E:IComparable<E>
        {
            foreach(E y in someEnumerable)
            {
                if (y.CompareTo(x) < 0)
                {
                    yield return y;
                }
            }
        }

    }
}
