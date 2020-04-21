using _02_array_sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace data_structure_test
{
    [TestClass]
    public class HeapSortingTest
    {
        [TestMethod]
        public void Test_Heap_Sort_When_Input_IsCorrect()
        {
            int[] array = new int[] { 10, 20, 5, 6, 9, 7 };

            HeapSorting.Sort(array);

            //CommonMethod.RunTestsForSortAlgorithm(HeapSorting.Sort);
        }
    }
}
