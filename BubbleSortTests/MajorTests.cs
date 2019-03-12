using BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BubbleSortTests
{
    [TestClass]
    public class MajorTests
    {
        private static Random Random { get; } = new Random();

        /// <summary>
        ///     Builds random int arrays (random lengths and values)
        ///     then stores them in the *arrList*
        /// </summary>
        /// <param name="arrList">Will store the random int arrays</param>
        private static void BuildRandomIntArrayList(List<int[]> arrList)
        {
            for (int j = 0; j < Random.Next(1, 10); j++)
            {
                List<int> intlist = new List<int>();
                for (int i = 0; i < Random.Next(2, 25); i++)
                {
                    intlist.Add(Random.Next(200));
                }
                arrList.Add(intlist.ToArray());
            }
        }

        /// <summary>
        ///     Tests if my Array.MyBubbleSort()'s results are identical to the Array.Sort()'s results
        ///     (Test Fails when mySort is not identical)
        /// </summary>
        [TestMethod]
        public void TestToMatchBuiltInSortMethod()
        {
            List<int[]> list = new List<int[]>();
            BuildRandomIntArrayList(list);

            foreach (int[] intArray in list)
            {
                List<int> temp = intArray.ToList();
                temp.Sort();
                int[] notMySort = temp.ToArray();
                int[] mySort = intArray.MyBubbleSort(null, (a, b) => a > b);

                for (int i = 0; i < intArray.Length; i++)
                {
                    if (notMySort[i] != mySort[i])
                    {
                        Assert.Fail("MyBubbleSort failed to sort completely");
                    }
                }
            }
        }
    }
}
