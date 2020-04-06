namespace _02_array_sorting
{
    public class QuickSorting
    {
        public static void Sort(int[] array) => QuickSort(array, 0, array.Length - 1);

        /// <summary>
        /// The main function that implements QuickSort()
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        /// <param name="low">Starting index</param>
        /// <param name="high">Ending index</param>
        private static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                //pi is partitioning index, arr[pi] is now at right place
                int pi = Partition(array, low, high);

                // Recursively sort elements before partition and after partition 
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        /// <summary>
        /// This function takes last element as pivot, places the pivot element at its correct position in sorted array, and places all
        ///  smaller(smaller than pivot) to left of pivot and all greater elements to right of pivot
        /// </summary>
        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high]; // selecting last element as pivot

            int i = low - 1; // index of smaller element

            for (int j = low; j < high; j++)
            {
                // if current element is smaller than the pivot
                if (array[j] < pivot)
                {
                    i++; // increment index of smaller element

                    //swap array[i] & array[j]
                    CommonMethod.Swap(array, i, j);
                }
            }

            CommonMethod.Swap(array, i + 1, high);

            return i + 1;
        }
    }
}
