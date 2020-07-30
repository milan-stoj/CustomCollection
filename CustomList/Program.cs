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
            LiteList<int> customList = new LiteList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);

            Console.WriteLine(customList.ToString());
            Console.ReadLine();


            LiteList<int> listOne = new LiteList<int>();
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            LiteList<int> listTwo = new LiteList<int>();
            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);

            LiteList<int> zipper = listOne.Zip(listTwo);

            Console.WriteLine(zipper.ToString());
            Console.ReadLine();

            LiteList<int> newList = listOne + listTwo;
            Console.WriteLine(newList.ToString());
            Console.ReadLine();

            
        }
    }
}
