namespace _02_array_sorting
{
    public class SelectionSorting
    {
        public static void Sort(int[] array)
        {
            // iterate and move boundary of unsorted subarray
            for (int i = 0; i < array.Length; i++)
            {
                // Find the index of minimum element in unsorted array
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //Swap the found minimum element with the first  element
                CommonMethod.Swap(array, i, minIndex);
            }
        }
    }
}
