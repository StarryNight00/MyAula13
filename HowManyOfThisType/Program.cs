using System;
using System.Collections;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] ordenada = { 1, 2, "ab", "ba", 'c', 'd', 17.4f, 1.5f, 20.0f };

            int numeroStrings = GetTotalComponents<string>(ordenada);
            int numeroFloats = GetTotalComponents<float>(ordenada);

            Console.WriteLine($"num Strings em 'ordenada' é {numeroStrings}");
            Console.WriteLine($"num Floats em 'ordenada' é {numeroFloats}");
            Console.ReadKey();
        }

        private static int GetTotalComponents<T>(IEnumerable someEnumerable)
        {
            int total = 0;
            foreach (object o in someEnumerable)
            {
                if (o is T) total++;
            }

            return total;
        }
    }
}