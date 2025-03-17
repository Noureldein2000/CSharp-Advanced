using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Generics
{
    internal class Person : IEnumerable<PayItem>
    {
      
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public IEnumerator<PayItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
