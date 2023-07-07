using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    //Array is a collection of same data type
    //Array index Start with 0.
    //we can store only fix set of element in array.
   public class ArrayDemo
    {
        public void Add()
        {
            int[] myArray= new int[10];
            string[] myArrays= new string[10];

            int[] obj=new int[] {1,2,3};

            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Array using a foreach loop");
            string[] strings = new string[4] {"rucha","mina","Rama","Sai"};
            foreach(string element  in strings) 
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Array using For Loop");
            string[] strings_Two = new string[] { "sima", "Rima", "Tina", "tanu", "sona" };

            for (int val = 0; val < strings_Two.Length; val++)
            {
                Console.WriteLine(strings_Two[val]);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Array Using while loop");
            int value = 0;
            while (value < strings_Two.Length)
            {
                Console.WriteLine(strings_Two[value]);
                value++;
            }
        }
    }
}
