﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class ArrayHelper
    {
        /// <summary>
        ///     Simple delegate to allow dev to pass in a lambda expression for comparing two ints
        ///     (This will be used in the MyBubbleSort method)
        /// </summary>
        /// <param name="a">First Number to compare</param>
        /// <param name="b">Second Number to compare</param>
        /// <returns>the result of the comparison between the two parameters will be returned as a bool</returns>
        public delegate bool SortBy(int a, int b);


        /// <summary>
        ///     
        /// </summary>
        /// <param name="array">The array you're trying to sort</param>
        /// <param name="numberOfPasses">if null is passed in then the default is to do passes until the array.Length is met</param>
        /// <param name="sortBy">how you want the array to be sorted</param>
        /// <returns>The sorted array ("how well it sorts depends on numberOfPasses")</returns>
        public static int[] MyBubbleSort(this int[] array, int? numberOfPasses, SortBy sortBy)
        {
            numberOfPasses = !numberOfPasses.HasValue ? array.Length : numberOfPasses;

            int[] result = (int[])array.Clone();

            // one iteration represents one pass over the array
            for (int j = 0; j < numberOfPasses; j++)
            {
                // one iteration represents one check on two elements
                for (int i = 0; i < result.Length; i++)
                {
                    int firstNumber = result[i];
                    int? secondNumber;

                    try
                    {
                        secondNumber = result[i + 1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        secondNumber = null;
                    }

                    if (secondNumber.HasValue && sortBy(firstNumber, secondNumber.Value))
                    {
                        result[i] = secondNumber.Value;
                        result[i + 1] = firstNumber;
                    }
                }
            }

            return result;
        }


        /// <summary>
        ///     Simple Method to output an int[] array's contents in one-line
        /// </summary>
        /// <param name="headerTitle">Text to the left of the array's content</param>
        /// <param name="array">Contents will be displayed in one-line</param>
        public static void DisplayNumbersOfArray(string headerTitle, int[] array)
        {
            Console.Write(headerTitle);
            for (int i = 0; i < array.Length; i++)
            {
                if ((i + 1) == array.Length)
                {
                    Console.Write($"{array[i]}\n\n");
                }
                else
                {
                    Console.Write($"{array[i]}, ");
                }
            }
        }
    }
}
