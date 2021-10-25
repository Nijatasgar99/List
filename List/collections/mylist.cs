using System;
using System.Collections.Generic;
using System.Text;

namespace List.collections
{
    public class mylist<T>
    {
        private T[] arr;
        //private static int count;
        public int Count { get; set; }
        public mylist()
        {
           
            arr = new T[10];
        }
        public void AddRange(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Add(item);
            }

        }
        public void Add(T obj)
        {
            if (Count%15==0)
            {
                arr[Count] = obj;
                Count++;
            }

        }
        private void ArrayResize()
        {
            Array.Resize(ref arr, arr.Length + 15); 
        }
        public void clear()
        {
            arr = new T[15];
            Count = 0;
        }
        public T Find(Predicate<T> func)

        {
            
            foreach (var item in arr)
            {
                if (func(item))
                {
                    return item;
                }
            }
            return default;

        }
        public bool Contains(T obj)
        {
            foreach (var item in arr)
            {
                if (Comparer<T>.Default.Compare(item, obj)==0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
