using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io_HW_Day4
{
    class MyList<T>
    {
        T[] items;
        T[] tempArray;
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
                //items'a geri alıyoruz. 
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
            Console.WriteLine(item);
        }
        public int Count
        {
            get { return items.Length; }
         
        }
        public T[] itemkey
        {
            get { return items; }
        }

    }
}
