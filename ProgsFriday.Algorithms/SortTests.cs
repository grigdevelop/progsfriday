using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ProgsFriday.Algorithms;
using System.Linq;
using ProgsFriday.Lib.Algorithms;

namespace ProgsFriday.Algorithms
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void TestMergeSort()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1, 11, 23, 11, 12, 22, 3, 1, 2, 3 };
            int[] expectedArray = array.OrderBy(x => x).ToArray();

            array.MergeSort(int.MaxValue);

            CollectionAssert.AreEqual(expectedArray, array);
        }

        [TestMethod]
        public void TestSelectionSort()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1, 11, 23, 11, 12, 22, 3, 1, 2, 3 };
            int[] expectedArray = array.OrderBy(x => x).ToArray();

            array.SelectionSort();

            CollectionAssert.AreEqual(expectedArray, array);
        }

        [TestMethod]
        public void TestInsertionSort()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1, 11, 23, 11, 12, 22, 3, 1, 2, 3 };
            int[] expectedArray = array.OrderBy(x => x).ToArray();

            array.InsertionSort();

            CollectionAssert.AreEqual(expectedArray, array);
        }

        [TestMethod]
        public void TestQuickSort()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1, 11, 23, 11, 12, 22, 3, 1, 2, 3 };
            int[] expectedArray = array.OrderBy(x => x).ToArray();

            array.QuickSort();

            CollectionAssert.AreEqual(expectedArray, array);
        }
    }
}
