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

            list.Remove(3);
            LiteList<int> customList = new LiteList<int>() /*{1,2,3,4,5} not working (!?)*/;
        }
    }
}
