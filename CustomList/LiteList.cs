﻿using System;
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

        public void Remove(T target) // Search for specific thing and remove one instance of it.
        {
            bool removed = false;
            T[] tempList = new T[capacity];
            int itemsIndex = 0;
            for (int i = 0; i < count; i++)
            {
                if(removed == false && target.Equals(items[i]))
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

        public void Zip()
        {

        }

        public void Sort()
        {

        }

        // Private LiteList methods
        private void CheckListSize()    // Checks for count == capacity, and runs DoubleListSize method
        {
            if (count == capacity)
            {
                DoubleListSize();
            }
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
    }
}
