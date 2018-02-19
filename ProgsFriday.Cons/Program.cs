using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProgsFriday.Lib.Algorithms;

namespace ProgsFriday.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] list = Enumerable.Range(1, 2228000).OrderBy(x => rd.Next()).ToArray();

            CalcTime(() =>
            {
                list.OrderBy(x => x);
            });

            CalcTime(() =>
            {
                list.QuickSort();
            });

            Console.ReadLine();
        }

        static void CalcTime(Action action)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            action();
            sw.Stop();
            var t = new TimeSpan(sw.ElapsedTicks);
            Console.WriteLine("Spend time: {0}", t.ToString());
        }
    }
}
