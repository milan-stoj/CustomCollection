using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CustomList
{
    public class LiteList<T> : IEnumerable
    {
        // Member variables
        private int count;
        private int capacity;
        private T[] items;

        // Member properties
        public T this[int index]                    // Declaring public indexer
        {
            get => items[index];
            set => items[index] = value;
        }
        public int Count { get => count; }          // Declaring public Count property
        public int Capacity { get => capacity; }    // Declaring public Capacity property

        // Constructor
        public LiteList()
        {
            count = 0; capacity = 4;
            items = new T[capacity];
        }

        // Public LiteList methods
        public void Add(T item)
        {
            items[count] = item; count++;
            CheckListSize();
        }

        public void RemoveLast()
        {
            items[count] = default(T);
            count--;
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < count; index++)
            {
                yield return items[index];
            }
        }

        public void Remove(T target) // Search for specific thing and remove one instance of it.
        {
            bool removed = false;
            T[] tempList = new T[capacity];
            int itemsIndex = 0;
            for (int i = 0; i < count; i++)
            {
                if (removed == false && target.Equals(items[i]))
                {
                    removed = true;
                    tempList[i] = items[itemsIndex + 1];
                    itemsIndex++;
                }
                else
                {
                    tempList[i] = items[itemsIndex];
                }
                itemsIndex++;
            }
            items = tempList;
            count--;
        }

        public LiteList<T> Zip(LiteList<T> zipList)
        {
            int maxCount = Math.Max(count, zipList.count);
            LiteList<T> newList = new LiteList<T>();
            for (int i = 0; i < maxCount; i++)
            {
                newList.Add(items[i]);
                newList.Add(zipList[i]);
            }
            return newList;
        }

        public override string ToString()
        {
            string tempString = "";
            foreach (T item in items)
            {
                tempString += "[" + item.ToString() + "]";
            }
            return tempString;
        }

        public static LiteList<T> operator +(LiteList<T> a, LiteList<T> b)
        {
            int maxCount = Math.Max(a.count, b.count);
            LiteList<T> newList = new LiteList<T>();
            for (int i = 0; i < maxCount; i++)
            {
                // Dynamic keyword allows operation to be resolved at run-time.
                dynamic x = a[i];                       
                dynamic y = b[i];
                newList.Add(x + y);
            }
            return newList;
        }

        public static LiteList<T> operator -(LiteList<T> a, LiteList<T> b) 
        {
            int maxCount = Math.Max(a.count, b.count);
            LiteList<T> newList = new LiteList<T>();
            for (int i = 0; i < maxCount; i++)
            {
                // Dynamic keyword allows operation to be resolved at run-time.
                dynamic x = a[i];      
                dynamic y = b[i];
                newList.Add(x - y);
            }
            return newList;
        }

        // Sorting using Bubble-sort algorithm:
        public void Sort()      
        {
            int i;
            int j;
            int count = this.count;
            for (j = count - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (Compare(this[i], this[i+1]) > 0) // > 0 means 
                    {
                        SwapElement(this, i, i + 1);
                    }
                }
            }
        }

        // Private LiteList methods
        private void CheckListSize()    // Checks for count == capacity, and runs DoubleListSize method
        {
            if (count == capacity)
            {
                DoubleListSize();
            }
        }

        private int Compare(T a, T b)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            return comparer.Compare(a, b);
        }

        private void SwapElement(LiteList<T> items, int indexA, int indexB)
        {
            T tempObject;
            tempObject = items[indexA];
            items[indexA] = items[indexB];
            items[indexB] = tempObject;
        }


        private void DoubleListSize()   // Doubles public array items capacity
        {
            capacity *= 2;                        
            T[] tempList = new T[capacity];
            for (int i = 0; i < count; i++) 
            {
                tempList[i] = items[i];
            }
            items = tempList;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
