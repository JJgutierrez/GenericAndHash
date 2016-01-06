using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListGeneAndHash
{
   
    public class GenericDictionary <TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            
        }
    }
    public class GenList<T,U>
    {
        public void Add(T key,T value)
        {
            using (StreamWriter write = File.AppendText(@"Gen.txt"))
            {
                write.WriteLine(key);
                write.Write(value);
                
            }
        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }
}
