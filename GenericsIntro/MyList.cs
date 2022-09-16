using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        public int Count
        {
            get
            {
                return items.Length;
            }
        }
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
          
            }
            items[items.Length - 1] = item;

        }
        public void Listele()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);

            }
        }




        //T[] items;
        //public MyList()
        //{
        //    items = new T[0];
        //}
        //public void Add(T item)
        //{
        //    T[] tempArray = items;
        //    items = new T[items.Length + 1];

        //    for (int i = 0; i < tempArray.Length; i++)
        //    {

        //        items[i] = tempArray[i];

        //        Console.WriteLine(items[i]+". elemani " + tempArray[i]);
        //    }
        //    items[items.Length - 1] = item;


        //}
    }
}
