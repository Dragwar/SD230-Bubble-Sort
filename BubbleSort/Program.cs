using System;

namespace BubbleSort
{
    public class Program
    {
        public static void Main()
        {
            int[] array = new int[] { 8, -1, 7, 9, 4, -10, 0, 6, 2 };

            Console.CursorVisible = false;

            Console.WriteLine("Original Array");
            for (int i = 0; i < array.Length; i++)
            {
                if ((i + 1) == array.Length)
                {
                    Console.Write($"{array[i]}");
                }
                else
                {
                    Console.Write($"{array[i]}, ");
                }
            }

            Console.ReadLine();
        }
    }
}
