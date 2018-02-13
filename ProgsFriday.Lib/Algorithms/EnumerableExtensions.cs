using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ProgsFriday.Lib.Algorithms
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> SetElement<T>(this IEnumerable<T> array, int index, T newElement)
        {
            T[] temp = array.ToArray();
            temp[index] = newElement;
            return temp;
        }

        public static IEnumerable<T> Swap<T>(this IEnumerable<T> array, int indexA, int indexB)
        {
            var tempArray = array.ToArray();
            var tempItem = tempArray[indexA];
            tempArray[indexA] = tempArray[indexB];
            tempArray[indexB] = tempItem;

            return tempArray;
        }

        public static void Swap<T>(this T[] array, int indexA, int indexB)
        {
            var tempItem = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = tempItem;
        }

        public static string ToArrayString<T>(this IEnumerable<T> list)
        {
            return (string.Join(", ", list));
        }

        public static T[] ToSizedArray<T>(this IEnumerable<T> list, int finalSize, T def)
        {
            int listSize = list.Count();
            int size = finalSize < listSize ? listSize : finalSize;
            T[] array = new T[size];
            for (int i = 0; i < listSize; i++)
                array[i] = list.ElementAt(i);
            for (int i = listSize; i < size; i++)
                array[i] = def;

            return array;
        }
    }
}
