using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
  public class ArrayListDemo
    {
        //ArrayList:- Its a non-generic collection
        //It is same as a array except its size increase dynamically.
        //It shows the element of multiple data type
        public void MyArrayList()
        { 
           ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Ruchita");
            arrayList.Add(13.5);
            arrayList.Add(789.09f);
            arrayList.Add('R');
            Console.WriteLine("ArrayList using foreach loop");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("ArrayList using for loop");

            for (var i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
