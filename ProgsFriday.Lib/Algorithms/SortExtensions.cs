using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgsFriday.Lib.Algorithms
{
    public static class SortExtensions
    {
        public static T[] MergeSort<T>(this T[] array, T def, IComparer<T> comparer = null)
        {
            if (comparer == null)
                comparer = Comparer<T>.Default;

            _MergeSort(array, 0, array.Length - 1, comparer, def);

            return array;

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

        private static void _MergeSort<T>(T[] array, int startIndex, int endIndex, IComparer<T> comparer, T def)
        {
            if (startIndex >= endIndex)
                return;

            int middle = (startIndex + endIndex) / 2;

            _MergeSort(array, startIndex, middle, comparer, def);
            _MergeSort(array, middle + 1, endIndex, comparer, def);
            Merge(array, startIndex, endIndex, middle, comparer, def);
        }

        private static void Merge<T>(T[] array, int startIndex, int endIndex, int middle, IComparer<T> comparer, T def)
        {
            // [1, 2, 3, 4, 5]
            //T[] leftArray = array.Skip(startIndex).Take(middle - startIndex + 1).ToArray();
            int arraysSize = endIndex - startIndex + 1;
            T[] leftArray = array.Skip(startIndex).Take(middle - startIndex + 1).ToSizedArray(arraysSize, def);
            T[] rightArray = array.Skip(middle + 1).Take(endIndex - middle).ToSizedArray(arraysSize, def);
            Console.Write("Left: {0}", leftArray.ToArrayString());
            Console.Write(" Right: {0}", rightArray.ToArrayString());
            Console.WriteLine();

            int leftIndex = 0, rightIndex = 0;
            for (int k = startIndex; k < endIndex + 1; k++)
            {
                if (comparer.Compare(leftArray[leftIndex], rightArray[rightIndex]) <= 0) // left smaller or equal
                {
                    array[k] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[k] = rightArray[rightIndex];
                    rightIndex++;
                }
            }
        }
    }
}
