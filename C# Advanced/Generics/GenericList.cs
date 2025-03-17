using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Generics
{
    //make constrain of condition to make T is refernce type only by add where T : class 
 
    internal class GenericList<T, T2> where T : class 
    {

        private List<T> _items = new List<T>();
        public int CountItem => _items.Count;

        public void add(T item) => _items.Add(item);
        public void remove(T item) => _items.Remove(item);


        //make constrain of condition to make T2 is Must be Number only by adding where T2 : INumber<T2>

        public T2 Sum<T2>(T2 t2, T2 t21) where T2 : INumber<T2> => t2 + t21;


    }
}
