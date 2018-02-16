using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgsFriday.Lib.Algorithms
{
    public static class SortExtensions
    {
        public static T[] MergeSort<T>(this T[] array, IComparer<T> comparer = null)
        {
            if (comparer == null)
                comparer = Comparer<T>.Default;

            _MergeSort(array, 0, array.Length - 1, comparer);

            return array;

        }

        public static void QuickSort<T>(this T[] array, IComparer<T> comparer = null)
        {
            if (comparer == null)
                comparer = Comparer<T>.Default;

            _QuickSort(array, 0, array.Length - 1, comparer);
        }

        public static void SelectionSort<T>(this T[] array, IComparer<T> comparer = null)
        {
            if (comparer == null)
                comparer = Comparer<T>.Default;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[j], array[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                array.Swap(i, smallest);
            }
        }

        public static void InsertionSort<T>(this T[] array, IComparer<T> comparer = null)
        {
            if (comparer == null)
                comparer = Comparer<T>.Default;

            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && comparer.Compare(array[j], key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        private static void _QuickSort<T>(T[] array, int startIndex, int endIndex, IComparer<T> comparer)
        {
            if (startIndex >= endIndex)
                return;

            int middleIndex = Partition(array, startIndex, endIndex, comparer);
            _QuickSort(array, startIndex, middleIndex - 1, comparer);
            _QuickSort(array, middleIndex + 1, endIndex, comparer);
        }

        private static int Partition<T>(T[] array, int startIndex, int endIndex, IComparer<T> comparer)
        {
            int middle = startIndex;
            for (int u = startIndex; u <= endIndex - 1; u++)
            {
                if (comparer.Compare(array[u], array[endIndex]) <= 0)
                {
                    array.Swap(u, middle);
                    middle++;
                }
            }

            array.Swap(middle, endIndex);

            return middle;
        }

        private static void _MergeSort<T>(T[] array, int startIndex, int endIndex, IComparer<T> comparer)
        {
            if (startIndex >= endIndex)
                return;

            int middle = (startIndex + endIndex) / 2;

            _MergeSort(array, startIndex, middle, comparer);
            _MergeSort(array, middle + 1, endIndex, comparer);
            Merge(array, startIndex, endIndex, middle, comparer);
        }

        private static void Merge<T>(T[] array, int startIndex, int endIndex, int middle, IComparer<T> comparer)
        {
            int leftSize = middle - startIndex + 1;
            int rightSize = endIndex - middle;
  
            T[] leftArray = new T[leftSize],
                rightArray = new T[rightSize];

            for (int i = 0; i < leftSize; i++)
                leftArray[i] = array[startIndex + i];
            for (int j = 0; j < rightSize; j++)
                rightArray[j] = array[middle + 1 + j];


            int leftIndex = 0, rightIndex = 0, currentIndex = startIndex;
            while (leftIndex < leftSize && rightIndex < rightSize)
            {
                if (comparer.Compare(leftArray[leftIndex], rightArray[rightIndex]) <= 0) // left smaller or equal
                {
                    array[currentIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[currentIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                currentIndex++;
            }

            while(leftIndex < leftSize)
            {
                array[currentIndex] = leftArray[leftIndex];
                leftIndex++;
                currentIndex++;
            }

            while (rightIndex < rightSize)
            {
                array[currentIndex] = rightArray[rightIndex];
                rightIndex++;
                currentIndex++;
            }
        }
    }
}
