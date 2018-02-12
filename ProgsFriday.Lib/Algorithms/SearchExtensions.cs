using ProgsFriday.Lib.Comparers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProgsFriday.Lib.Algorithms
{
    public static class SearchExtensions
    {
        /// <summary>
        /// Gets the index of first founded item
        /// </summary>
        /// <typeparam name="T">The type of array</typeparam>
        /// <param name="array">Input array</param>
        /// <param name="value">Value of searching item</param>
        /// <param name="equalityComparer">Custom comparer</param>
        /// <returns>The index of founded item or -1 if not found</returns>
        public static int LinearSearch<T>(this IEnumerable<T> array, T value, IEqualityComparer<T> equalityComparer = null)
        {
            if (equalityComparer == null)
                equalityComparer = new DefaultEqualityComparer<T>();

            int foundIndex = -1;

            for (int i = 0; i < array.Count(); i++)
            {
                if (equalityComparer.Equals(array.ElementAt(i), value))
                {
                    foundIndex = i;
                    break;
                }
            }

            return foundIndex;
        }

        /// <summary>
        /// Gets the index of first founded item
        /// </summary>
        /// <typeparam name="T">The type of array</typeparam>
        /// <param name="array">Input array</param>
        /// <param name="value">Value of searching item</param>
        /// <param name="equalityComparer">Custom comparer</param>
        /// <returns>The index of founded item or -1 if not found</returns>
        public static int BetterLinearSearch<T>(this IEnumerable<T> array, T value, IEqualityComparer<T> equalityComparer = null)
        {
            if (equalityComparer == null)
                equalityComparer = new DefaultEqualityComparer<T>();

            int arrayLength = array.Count();

            T lastItem = array.Last();
            array = array.SetElement(arrayLength - 1, value);
            int index = 0;
            while (!equalityComparer.Equals(array.ElementAt(index), value))
                index++;

            if (index < arrayLength - 1)
                return index;

            if (equalityComparer.Equals(lastItem, value))
                return arrayLength - 1;

            return -1;
        }
    }
}
