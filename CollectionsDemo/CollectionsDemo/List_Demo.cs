using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    //List<T> class represents the list of objects which can be accessed with index 
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
        }

    }
}
