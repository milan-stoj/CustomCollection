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
            int[] array = new int[] { 1, 2, 3 };
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            list.Remove(1);
            int test = list[4];

            list.Remove(3);
            LiteList<int> customList = new LiteList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);

            customList.Remove(4);
            int newTest = customList[4];
        }
    }
}
