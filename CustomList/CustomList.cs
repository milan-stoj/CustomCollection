using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables
        private int count;
        private int capacity;
        private T[] list;
        public T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public int Count
        {
            get => count;
        }

        public int Capacity
        {
            get => capacity;
        }

        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            list = new T[capacity];
        }



        //Methods
        public void Add(T item)
        {
            list[count] = item;
            count++;
            CheckListSize();
        }

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
                tempList[i] = list[i];
            }
            list = tempList;
        }

        public void Remove()
        {
            list[count] = default(T);
            count--;
        }

        public void Zip()
        {

        }

        public void Sort()
        {

        }
    }
}
