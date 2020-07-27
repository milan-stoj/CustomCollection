/****************************************************/
// Filename: ListLite
// Created: Milan Stojanovic
/****************************************************/

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
        public T this[int index] { get => items[index]; set => items[index] = value; }
        public int Count { get => count; }
        public int Capacity { get => capacity; }

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
        {
            if (count == capacity)
            {
                DoubleListSize();
            }
        }

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
