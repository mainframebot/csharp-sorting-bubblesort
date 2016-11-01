using System;

namespace BubbleSortExample
{
    internal static class BubblesortCommon<T>
        where T : IComparable<T>
    {
        internal static bool Less(T i, T j)
        {
            return i.CompareTo(j) < 0;
        }

        internal static void Swap(T[] items, int i, int j)
        {
            var temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }
    }
}
