namespace _02_array_sorting
{
    /// <summary>
    /// Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
    /// </summary>
    public class BubbleSorting
    {
        /// <summary>
        /// This method always runs O(n^2) time even the array is sorted. 
        /// </summary>
        /// <param name="array">Array to sort</param>
        public static void Sort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    //if we add >= this algo will become unstable as relative order of duplicate values change
                    if (array[i] > array[i + 1]) 
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        /// <summary>
        /// The above Sort method can be optimized by stopping the alogorithm if inner loop didn't cause any swap.
        /// </summary>
        /// <param name="array">Array to sort</param>
        public static void OptimizeSort(int[] array)
        {
            bool swapped = false;
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                        swapped = true;
                    }

                    //if no two element were swapped by inner loop, then break
                    if (!swapped)
                        break;
                }
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
