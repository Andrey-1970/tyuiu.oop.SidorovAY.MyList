using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.oop.SidorovAY.MyList
{
    public class MyList<T>
    {
        private const int incrementCount = 2;
        private T[] items;
        private int count;
        public MyList()
        {
            items = new T[incrementCount];
            count = 0;
        }
        public int Count => count;
        public void Add(T item)
        {
            Items[count] = item;
            count++;
        }

        private T[] Items
        {
            get
            {
                if (count == items.Length)
                {
                    var newItems = new T[items.Length + incrementCount];
                    items.CopyTo(newItems, 0);
                    items = newItems;
                }
                return items;
            }
        }

        //public T GetItem(int index)
        //{
        //    return items[index];
        //}
        public T this[int index]
        {
            get
            {
                if (index >= count) throw new ArgumentException($"{index} out of range");
                return items[index];
            }
        }
    }
}
