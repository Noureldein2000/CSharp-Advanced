using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.LINQ
{
    internal class Student<T>
    {
        public Student()
        {
            Ids = new List<T>();
        }
        public List<T> Ids { get; set; }
        public void addId(T id) => Ids.Add(id);
        public void removeId(T id) => Ids.Remove(id);

        public IEnumerable<T> SortedIds(bool desc = false)
        {
            //Sorting
            var ids = from id in Ids where desc == true orderby id descending select id;

            var ids2 = desc ? Ids.OrderByDescending(s => s) : ids.OrderBy(s => s);
            return ids2;
        }

        public IEnumerable<T> IdsReverse() => SortedIds(true).Reverse();


    }
}
