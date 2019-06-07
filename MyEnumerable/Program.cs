using System;

namespace MyGenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<int> g3 = new Guarda3<int>();

            g3.SetItem(0, 23);

            int i = g3.GetItem(0);

            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}