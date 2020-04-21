using _02_array_sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace data_structure_test
{
    [TestClass]
    public class MergeSortingTest
    {
        [TestMethod]
        public void Test_Merge_Sort_When_Valid_Input()
        {
            CommonMethod.RunTestsForSortAlgorithm(MergeSorting.Sort);
        }

        [TestMethod]
        public void Test_Merge_Sort_When_Valid_Input1()
        {
            MergeSorting.Sort(new int[] { 4, 3, 2, 10, 12, 1, 5, 6 });
        }
    }
}
