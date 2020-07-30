using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            LiteList<int> listA = new LiteList<int>() { 15, 20, 25 };
            LiteList<int> listB = new LiteList<int>() { 12, 25, 14 };
            LiteList<int> newList = listA - listB;
            foreach(int item in newList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
