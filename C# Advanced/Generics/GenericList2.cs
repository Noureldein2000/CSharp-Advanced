using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Generics
{
    //make constrain of condition to make T is refernce type only by add where T : class 
    //and also T should have constractor less paramter (don't have any paramter in Constructor)
 
    internal class GenericList2<T> where T : class ,new ()
    {

        private List<T> _items = new List<T>();
        public int CountItem => _items.Count;

        public void add(T item) => _items.Add(item);
        public void remove(T item) => _items.Remove(item);


    }
}
