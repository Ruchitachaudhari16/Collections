using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    //List<T> class represents the list of objects which can be accessed with index 
    //list is dynamic ,we can resize the list.
    public class List_Demo
    {
        //creating a list of integers.
        List<int>list= new List<int>();

        public void Adding()
        {
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Number of count in a list: " +list.Count);
            Console.WriteLine("Capacity of list"+list.Capacity);
            list.Add(5);
            list.Add(6);
            Console.WriteLine("Capacity of list"+list.Capacity);
            Console.WriteLine("find Element"+list.Contains(1));
            Console.WriteLine("Find Element in list"+list.Contains(12));
            Console.WriteLine("remove element at index position");
            list.RemoveAt(1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("value in a reverse order");

            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("list in a sorted order");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
