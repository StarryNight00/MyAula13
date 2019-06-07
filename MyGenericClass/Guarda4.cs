using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyGenericClass
{
    public class Guarda4<T> : IEnumerable<T>
    {
        private T x, y, z;

        public Guarda4()
        {
            x = default(T);
            y = default(T);
            z = default(T);
        }

        public T GetItem(int i)
        {
            if (i == 0) return x;
            if (i == 1) return y;
            if (i == 2) return z;
            throw new IndexOutOfRangeException();
        }

        public void SetItem(int i, T item)
        {
            if (i == 0) x = item;
            else if (i == 1) y = item;
            else if (i == 2) z = item;
            else throw new IndexOutOfRangeException();
        }
        
        public void Add(T item)
        {
            if (x.Equals(default(T)))
                x = item;
            else if (y.Equals(default(T)))
                y = item;
            else if (Equals(z, default(T)))     //formato alternativo ao método Equals
                z = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
