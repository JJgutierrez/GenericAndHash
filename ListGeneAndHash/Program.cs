using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneAndHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int num = int.Parse(Console.ReadLine());
            var number = new Nullable<int>(num);

            Console.WriteLine("Has a value ?"+ number.HasValue);
            Console.WriteLine("Value"+ number.GetValueOrDefault());

            Console.WriteLine("enter a number :");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a Name :");
            string name = Console.ReadLine();

            var Nlist = new GenericDictionary<int,string>();
            Nlist.Add(index, name);

        }
    }
}
