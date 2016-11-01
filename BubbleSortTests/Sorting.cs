using System;
using System.Linq;
using BubbleSortExample;
using NUnit.Framework;

namespace BubbleSortTests
{
    [TestFixture]
    public class Sorting
    {
        internal Bubblesort<int> BubbleSort = new Bubblesort<int>();
        internal BubblesortOptimized<int> BubblesortOptimized = new BubblesortOptimized<int>();

        //+-------------------------------------------------------------------------------------------------------------------------+
        //| Pass 1                                || Pass 2                                || Pass 3                                |
        //+-------------------------------------------------------------------------------------------------------------------------+
        //|                                       ||                                       ||                                       |
        //| 9 <> 8 7 4 5 6                        || 8 <> 7 4 5 6 9                        || 7 <> 4 5 6 8 9                        |
        //|                                       ||                                       ||                                       |
        //| 8 9 <> 7 4 5 6                        || 7 8 <> 4 5 6 9                        || 4 7 <> 5 6 8 9                        |
        //|                                       ||                                       ||                                       |
        //| 8 7 9 <> 4 5 6                        || 7 4 8 <> 5 6 9                        || 4 5 7 <> 6 8 9                        |
        //|                                       ||                                       ||                                       |
        //| 8 7 4 9 <> 5 6                        || 7 4 5 8 <> 6 9                        || 4 5 6 7 8 9                           |
        //|                                       ||                                       ||                                       |
        //| 8 7 4 5 9 <> 6                        || 7 4 5 6 8 9                           ||                                       |
        //|                                       ||                                       ||                                       |
        //| 8 7 4 5 6 9                           ||                                       ||                                       |
        //|                                       ||                                       ||                                       |
        //|                                       ||                                       ||                                       |
        //+-------------------------------------------------------------------------------------------------------------------------+
        //| i = 0                                 || i = 1                                 || i = 2                                 |
        //+-------------------------------------------------------------------------------------------------------------------------+

        [Test]
        public void Bubblesort_Predetermined_Test_Should_Sort()
        {
            int[] items = {9, 8, 7, 4, 5, 6};
            int[] result = {4, 5, 6, 7, 8, 9};

            BubbleSort.Sort(items);

            Assert.AreEqual(result, items);
        }

        [Test, Repeat(10)]
        public void Bubblesort_Randomized_Test_Should_Sort()
        {
            int[] items = GenerateRandomArray();
            int[] result = items.OrderBy(x => x).ToArray();

            BubbleSort.Sort(items);

            Assert.AreEqual(result, items);
        }

        [Test]
        public void BubblesortOptimized_Predetermined_Test_Should_Sort()
        {
            int[] items = { 9, 8, 7, 4, 5, 6 };
            int[] result = { 4, 5, 6, 7, 8, 9 };

            BubblesortOptimized.Sort(items);

            Assert.AreEqual(result, items);
        }

        [Test, Repeat(10)]
        public void BubblesortOptimized_Randomized_Test_Should_Sort()
        {
            int[] items = GenerateRandomArray();
            int[] result = items.OrderBy(x => x).ToArray();

            BubblesortOptimized.Sort(items);

            Assert.AreEqual(result, items);
        }

        private int[] GenerateRandomArray()
        {
            var min = 0;
            var max = 99;

            var random = new Random();

            return Enumerable
                .Repeat(0, 10)
                .Select(i => random.Next(min, max))
                .ToArray();
        }
    }
}
