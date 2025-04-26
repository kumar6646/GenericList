using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            mylist.Add(10);
            mylist.Add(20);
            mylist.Add(30);
            mylist.Add(40);
            mylist.Add(50);
            Console.WriteLine("mylist elements are");
            foreach (int i in mylist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("pop element is" + mylist.Remove(10));
            //Console.WriteLine("peek element is" + mylist.RemoveAt(1);
            foreach (int i in mylist)
            {
                Console.WriteLine(i);
            }
            int[] arr = new int[5];
            mylist.CopyTo(arr, 1);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            mylist.Clear();
            Console.WriteLine("my stack elements are" + mylist.Count);

        }
    }
}
