using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneAndHash
{
   
    public class GenericDictionary <TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
    public class GenList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }
}
