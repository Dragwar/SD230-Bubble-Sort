using System;

namespace BubbleSort
{
    public class Program
    {
        public static void Main()
        {
            Console.CursorVisible = false;

            // Solution looks like: { -10, -1, 0, 2, 4, 6, 7, 8, 9 };
            int[] array = new int[] { 8, -1, 7, 9, 4, -10, 0, 6, 2 };
            ArrayHelper.DisplayNumbersOfArray("Original Array: ", array);

            // My sort
            int[] sortedArray = array.MyBubbleSort((a, b) => a > b);
            ArrayHelper.DisplayNumbersOfArray("Result Array:  ", sortedArray);

            Console.WriteLine("Press any key to exit . . .");
            Console.ReadKey(false);
        }
    }
}
