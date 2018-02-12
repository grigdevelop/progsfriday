using System.Collections.Generic;

namespace ProgsFriday.Lib.Comparers
{
    public class DefaultEqualityComparer<T> : IEqualityComparer<T>
    {
        public bool Equals(T x, T y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }
    }
}
