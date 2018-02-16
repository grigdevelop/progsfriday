using System;
using System.Collections;
using System.Collections.Generic;
using ProgsFriday.Lib.Algorithms;

namespace ProgsFriday.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 5, 4, 3, 2, 1, 11, 23, 11, 12, 22, 3, 1, 2, 3 };
            list.MergeSort();

            Console.WriteLine(string.Join(",", list));
            Console.ReadLine();
        }
    }
}
