namespace _02_array_sorting
{
    public class InsertionSorting
    {
        public static void Sort(int[] array)
        {
            int i, j, key;
            //iterate from 2nd element of the array
            for (i = 1; i < array.Length; i++)
            {
                j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    key = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = key;
                    j--;
                }
            }
        }
    }
}
