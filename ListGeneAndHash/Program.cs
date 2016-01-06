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
            Console.WriteLine("Enter a number  :");
            string num = Console.ReadLine();
            int num1 = int.Parse(num);
            var number = new Nullable<int>(num1);

            Console.WriteLine("Has a value ?:  "+ number.HasValue);
            Console.WriteLine("Value :  "+ number.GetValueOrDefault());
            Console.WriteLine("");

            Console.WriteLine("enter a number :");
            string index = Console.ReadLine();
            Console.WriteLine("enter a Name :");
            string name = Console.ReadLine();

            var Nlist = new GenericDictionary<string,string>();
            Nlist.Add(index, name);

            var NList2 = new GenList<string,string>();
            NList2.Add(index,name);

            List<string> NewList = new List<string> { index, name, num };
            Console.WriteLine(NewList.LongCount());

            Console.WriteLine("choose 1, 2 or 3");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NewList[n-1]);


        }
    }
}
