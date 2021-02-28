using System;
using проба4.Model;

namespace проба4
{
    class Program
    {
        static void Main(string[] args)
        {
            var duplexList = new DuplexLinkedList<int>();
            duplexList.Add(1);
            duplexList.Add(2);
            duplexList.Add(3);
            duplexList.Add(4);
            duplexList.Add(5);

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            duplexList.Delete(3);
           
            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            duplexList.InsertAfter(2, 7);
            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }
            var reverse = duplexList.Reverse();
            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
