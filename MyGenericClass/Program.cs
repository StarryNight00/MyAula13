using System;

namespace MyGenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda4<int> g3 = new Guarda4<int>();

            g3.SetItem(0, 23);
            g3.SetItem(1, -19);
            g3.SetItem(2, 5);

            Guarda4<int> g4 = new Guarda4<int>() {2, 4, 6, 7, 5};

            foreach(int i in g3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            foreach (int i in g4)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
