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
    }
}
