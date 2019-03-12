using System;

namespace BubbleSort
{
    public class Program
    {
        public static void Main()
        {
            int[] array = new int[] { 8, -1, 7, 9, 4, -10, 0, 6, 2 };
            Console.CursorVisible = false;

            RunMyBubbleSort(array);

            Console.WriteLine("Press any key to exit . . .");
            Console.ReadKey(false);
        }

        public static void RunMyBubbleSort(int[] array)
        {
            ArrayHelper.DisplayNumbersOfArray("Original Array: ", array);

            int[] sortedArray = array.MyBubbleSort(null, (a, b) => a > b);

            ArrayHelper.DisplayNumbersOfArray("Result Array:  ", sortedArray);
        }
    }

}
