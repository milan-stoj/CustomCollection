using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class LiteList<T>
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
            items = new T[capacity]ts;

        }

        // Public LiteList methods
        public void Add(T item)
        {
            items[count] = item; count++;
            CheckListSize();
        }

        public void Remove()
        {
            items[count] = default(T);
            count--;
        }

        public void Zip()
        {

        }

        public void Sort()
        {

        }

        // Private LiteList methods
        private void CheckListSize()
        // Checks to see if list size
        // reaches capacity.
        {
            if (count == capacity)
            {
                DoubleListSize();
            }
        }

        private void DoubleListSize()
        // Upon reaching capacity - array 
        // is copied to tempArray, new array doubled in
        // size, and items copied to new larger array.
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
