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
        // --- CLASS INSTANTIATION --- 
        // member variables
        private int count;
        private int capacity;
        private T[] items;

        // member properties
        public T this[int index]                    // Declaring public indexer
        {
            get => items[index];
            set => items[index] = value;
        }
        public int Count { get => count; }          // Declaring public Count property
        public int Capacity { get => capacity; }    // Declaring public Capacity property

        // constructor
        public LiteList()
        {
            count = 0; capacity = 4;
            items = new T[capacity];
        }

        // --- PUBLIC LITE LIST METHODS ---
        // adds an item to the list
        public void Add(T item)
        {
            items[count] = item; count++;
            CheckListSize();
        }

        // removes the last member of the list
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

        // search for specific thing and remove one instance of it
        public void Remove(T target) 
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

        // zips the lists together (i.e. {1,2,3}.zip({5,6,7}) = {1,5,2,6,3,7})
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

        // overrides the ToString method
        // converts each object to a string and encapsulates with brackets
        public override string ToString()
        {
            string tempString = "";
            foreach (T item in items)
            {
                tempString += "[" + item.ToString() + "]";
            }
            return tempString;
        }

        // overrides the "+" operator and allows lists to be added together
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

        // overrides the "-" operator and allows lists to be subtracted
        public static LiteList<T> operator -(LiteList<T> a, LiteList<T> b) 
        {
            int maxCount = Math.Max(a.count, b.count);
            LiteList<T> newList = new LiteList<T>();
            for (int i = 0; i < maxCount; i++)
            {
                // dynamic keyword allows operation to be resolved at run-time.
                dynamic x = a[i];      
                dynamic y = b[i];
                if (x-y > 0)
                {
                    newList.Add(x - y);
                }
            }
            return newList;
        }

        // sorts list using bubble-sort algorithm
        public void Sort()      
        {
            int i; int j;
            int count = this.count;
            for (j = count - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (Compare(this[i], this[i+1]) > 0)
                    {
                        SwapElement(i, i + 1);
                    }
                }
            }
        }

        // --- PRIVATE LITELIST METHODS ---
        // checks for count == capacity, and runs DoubleListSize method
        private void CheckListSize()   
        {
            if (count == capacity)
            {
                DoubleListSize();
            }
        }

        // compares two objects of type T.
        // returns 1 if a greater than b.
        // returns 0 if equal.
        // returns -1 if a less than b.
        private int Compare(T a, T b)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            return comparer.Compare(a, b);
        }

        // swaps element of list
        private void SwapElement(int indexA, int indexB)
        {
            T tempObject;
            tempObject = this[indexA];
            this[indexA] = this[indexB];
            this[indexB] = tempObject;
        }

        // Doubles public array items capacity
        private void DoubleListSize()
        {
            capacity *= 2;                        
            T[] tempList = new T[capacity];
            for (int i = 0; i < count; i++) 
            {
                tempList[i] = items[i];
            }
            items = tempList;
        }
    }
}
