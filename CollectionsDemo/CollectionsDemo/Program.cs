using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Program
    {
        //Collection is a class that means we can create an object.
        //can be create or declared instance of a class, so we can add a data in collections
        //Collections types- are designed to store ,manage similar data.

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("choose the below options");
                Console.WriteLine("1:List");
                Console.WriteLine("2:Array");
                Console.WriteLine("3:ArrayList");
                Console.WriteLine("4:Dictionary");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List_Demo list = new List_Demo();
                        list.Adding();
                        break;

                    case 2:
                        ArrayDemo arrayDemo = new ArrayDemo();
                        arrayDemo.Add();
                        break;

                        case 3:
                        ArrayListDemo arrayListDemo = new ArrayListDemo();
                        arrayListDemo.MyArrayList();
                        break;

                    case 4:
                        DictionaryDemo dictionaryDemo = new DictionaryDemo();
                        dictionaryDemo.Display();
                        break; 

                        Console.ReadLine();
                }
            }
        }
    }
}

