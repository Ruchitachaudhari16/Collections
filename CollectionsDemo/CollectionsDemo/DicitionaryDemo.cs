using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    //Dicitionary:- It a generic collection 
    //It will store key value pair.
    // Define under System.collections.namespace
    //Its a dynamic in nature
    //In a dictionary key cant be null but value can be.
    //key must be unique,duplicate key are not all
    //We can store only same data type value
    public class DictionaryDemo
    {
        public void Display()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("One", "Mumbai");
            keyValuePairs.Add("Two","Pune");
            keyValuePairs.Add("Three", "Bangalore");
            keyValuePairs.Add("Four","Chennai");

            //Print the value for key 
            Console.WriteLine("Print the value of key");
            Console.WriteLine(keyValuePairs["Two"]);
            Console.WriteLine("---------------------------------------");


            //Modify the value of key 
            Console.WriteLine("Modify the key value");
            keyValuePairs["Two"] = "Nagpur";
            Console.WriteLine(keyValuePairs["Two"]);
            Console.WriteLine("----------------------------------------");


            //Print dictionary using for each loop
            Console.WriteLine("Dictionary using for each loop");

            //Remove element from dictionary
            keyValuePairs.Remove("Three");

            foreach (KeyValuePair<string, string> element in keyValuePairs)
            {
                Console.WriteLine(element.Key +":" +element.Value);
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Dictionary using for loop");
            for (int i = 0; i < keyValuePairs.Count; i++)
            {
                var item=keyValuePairs.ElementAt(i);
                Console.WriteLine(item.Value);
            }
        } 
    }
}
