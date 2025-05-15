using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    /*
     * 
     * Key Benefits of Generics:  Code Reusability – Write once, use with multiple data types.
Type Safety – Prevents runtime errors due to type mismatches.
    Performance Optimization – Eliminates typecasting overhead.

     * In C#, a List is a generic collection used to store the elements or objects in the form of a list 
     * defined under System.Collection.Generic namespace. It provides the same functionality as ArrayList,
     * the difference is a list is generic whereas ArrayList is a non-generic collection. 
     * It is dynamic means the size of the list grows, according to the need.
     * This Generic List<T> Collection Class represents a strongly typed list of objects which 
     * can be accessed by using the integer index which is starting from 0. 
     * It also provides lots of methods that can be used for searching, sorting, 
     * and manipulating the list of items.

We can create a collection of any data type by using the Generic List<T> Collection Class in C#. 
    For example, if you want then you can create a list of strings,
    a list of integers, and a list of doubles,
    and it is also possible to create a list of user-defined complex types such as a list of customers,
    a list of products, a list of students, etc. 
    The most important point that you need to keep in mind is the size of the collection grows
    automatically when we add items to the collection.



The List class implements the ICollection<T>, IEnumerable<T>, IList<T>, IReadOnlyCollection<T>, 
    IReadOnlyList<T>, ICollection, IEnumerable, and IList interface.
It can accept null as a valid value for reference types and also allows duplicate elements.
If the Count becomes equal to Capacity, then the capacity of the List increases automatically 
    by reallocating the internal array. The existing elements will be copied to the new array
    before the addition of the new element.
The elements present in the list are not sorted by default and elements are accessed by zero-based index.

     */
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            list.Add("ABC");
            list.Add("XYZ");
            list.Add("JKL");
            list.Add("Ramu");
            foreach (var item in list)
            {
                {
                    Console.WriteLine(item);
                }
            }
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove("Ramu");
            list.RemoveAt(0);


            //Console.WriteLine(list.Count);
            //list.Remove("ABC");
            //list.RemoveAt(1);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(list.Count);
            list.Clear();

            Console.WriteLine(list.Count);


                List<int> mylist = new List<int>();
                mylist.Add(10);
                mylist.Add(20);
                mylist.Add(30);
                mylist.Add(40);
                mylist.Add(50);
                mylist.Add(60);
            mylist.Add(2000);
                Console.WriteLine("mylist elements are");
                foreach (int i in mylist)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("remove element is" + mylist.Remove(10));
                //int[] ars = new int[1];

                //Console.WriteLine("peek element is" + mylist.RemoveAt(1);
                foreach (int i in mylist)
                {
                    Console.WriteLine(i);
                }
            int[] arrs = new int[6];
            mylist.CopyTo(arrs,0);
            foreach (int i in arrs)
            {
                Console.WriteLine(i);
            }
                int[] arr = new int[6];
                // mylist.CopyTo(arr, 0);
                mylist.CopyTo(arr, 1);
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
                // mylist.Clear();
                mylist.Clear();
                Console.WriteLine("my stack elements are" + mylist.Count);

            }
        }
    }











/*
 * IEnumerable is an interface in C# that allows iteration over a collection. It is part of the System.Collections namespace for non-generic collections and System.Collections.Generic for generic collections.
Key Features:
- It defines the GetEnumerator() method, which returns an enumerator to iterate through the collection.
- It supports foreach loops, making it easier to traverse collections.
- It is read-only, meaning you can iterate over elements but cannot modify them.
Difference Between IEnumerable and IEnumerator:
- IEnumerable provides an enumerator (IEnumerator) for iteration.
- IEnumerator has methods like MoveNext(), Reset(), and a Current property to access elements.
Would you like an exa

 */