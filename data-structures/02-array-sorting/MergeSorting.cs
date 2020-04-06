namespace _02_array_sorting
{
    public class MergeSorting
    {
        public static void Sort(int[] array) => MergeSort(array, 0, array.Length - 1);

        /// <summary>
        /// Merge sort funcion
        /// </summary>
        /// <param name="array">Array to sort</param>
        /// <param name="p">Starting index of the array</param>
        /// <param name="r">Last index of the array</param>
        private static void MergeSort(int[] array, int p, int r)
        {
            int q;
            if (p < r)
            {
                q = (p + r) / 2;
                MergeSort(array, p, q);
                MergeSort(array, q + 1, r);
                Merge(array, p, q, r);
            }
        }

        /// <summary>
        /// Function to merge the sub arrays
        /// </summary>
        /// <param name="array">Array to sort</param>
        /// <param name="p">Starting index of the array</param>
        /// <param name="q">Mid index of the array</param>
        /// <param name="r">Last index of the array</param>
        private static void Merge(int[] array, int p, int q, int r)
        {
            int[] b = new int[array.Length]; //same size
            int i, j, k;
            k = 0;
            i = p;
            j = q + 1;

            while (i <= q && j <= r)
            {
                if (array[i] < array[j])
                {
                    b[k++] = array[i++];
                }
                else
                {
                    b[k++] = array[j++];
                }
            }
            while (i <= q)
            {
                b[k++] = array[i++];
            }

            while (j <= r)
            {
                b[k++] = array[j++];
            }

            for (i = r; i >= p; i--)
            {
                array[i] = b[--k];  // copying back the sorted list to a[]
            }
        }
    }
}
