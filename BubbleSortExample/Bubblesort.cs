using System;

namespace BubbleSortExample
{
    public class Bubblesort<T>
        where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            var count = items.Length;

            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < count - 1; j++)
                {
                    if (BubblesortCommon<T>.Less(items[j + 1], items[j]))
                        BubblesortCommon<T>.Swap(items, j + 1, j);
                }
            }
        }
    }
}
