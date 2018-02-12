using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

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
    }
}
