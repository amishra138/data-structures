using System;
using System.Text;

namespace ProgrammingTest.Array
{
    public class ArrayRotation
    {
        public static void RotateArray()
        {
            LeftRotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2);
        }

        private static void LeftRotate(int[] arr, int d)
        {
            for (int i = 0; i < d; i++)
            {
                LeftRotateByOne(arr, d);
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                System.Console.WriteLine(arr[i] + " ");
            }
        }

        /// <summary>
        /// Function to left rotate array by d
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="d"></param>
        private static void LeftRotateByOne(int[] arr, int d)
        {
            int i, temp = arr[0];

            for (i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[i] = temp;
        }


    }
}
