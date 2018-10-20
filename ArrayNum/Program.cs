using System;
using System.Collections.Generic;

namespace ArrayNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Nm();
        }

        public static void Nm()
        {
            List<int> list1 = new List<int>(); // Declearing list one 
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            List<int> list2 = new List<int>(); // Declearing list two
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);

            List<int> list3 = new List<int>(); // Declearing list three (empty)
            int n = list1.Count;               // list1 length wich is equal to list2 lingth
            int i;
            for (i = 0; i < n; i++) // iterate through lists to add elements alternatingly to list3
            {
                list3.Add(list1[i]);// first we add element from list1
                list3.Add(list2[i]);// then we add element from list2
            }
            Console.Write("\n\nCombine two lists by alternatingly taking elements.\n");
            foreach (int s in list3)
            {
                Console.Write(s);
            }

            Console.Read();
        }
    }
}
