using System;

namespace _01_time_complexity
{
    public class ArrayTimeComplexity
    {
        /// <summary>
        /// access by index from array
        /// searching for an element takes O(n) time
        /// </summary>
        /// <param name="array"></param>
        public static void AccessByIndex(object[] array)
        {
            //O(1)
            Console.WriteLine(array[0]);

            int length = array.Length;
            object elementToFind = new object();
            for (int i = 0; i < length; i++)
            {
                if (array[i] == elementToFind)
                {
                    Console.WriteLine("Exists/Found");
                }
            }

            //add to a full array
            var bigArray = new int[length * 2];

            Array.Copy(array, bigArray, length); // Must faster then for loop
            bigArray[length + 1] = 10;

            //add to the end when there's some space
            //O(1) as we are adding to a known index
            array[length - 1] = 10;

            //O(1)
            array[6] = null;
        }

        public static void RemoveAt(object[] array, int index)
        {
            var newArrary = new object[array.Length - 1];
            Array.Copy(array, 0, newArrary, 0, index);
            Array.Copy(array, index + 1, newArrary, index, array.Length - 1 - index);

        }
    }
}
