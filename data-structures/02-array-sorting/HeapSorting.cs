namespace _02_array_sorting
{
    public class HeapSorting
    {
        public static void Sort(int[] array)
        {
            int n = array.Length;

            //build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            //one by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                //Move current root to end
                CommonMethod.Swap(array, 0, i);

                //call max heapify on the reduced heap
                Heapify(array, i, 0);
            }
        }

        /// <summary>
        /// To heapify a subtree rooted with node i which is an index in arr[]. n is size of heap 
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="n">Size of heap</param>
        /// <param name="i">An index in array</param>
        private static void Heapify(int[] array, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int left = 2 * i + 1; // left = 2*i + 1 
            int right = 2 * i + 2; // right = 2*i + 2 

            // If left child is larger than root 
            if (left < n && array[left] > array[largest])
                largest = left;

            // If right child is larger than largest so far 
            if (right < n && array[right] > array[largest])
                largest = right;

            // If largest is not root 
            if (largest != i)
            {
                CommonMethod.Swap(array, i, largest);

                // Recursively heapify the affected sub-tree 
                Heapify(array, n, largest);
            }
        }
    }
}
