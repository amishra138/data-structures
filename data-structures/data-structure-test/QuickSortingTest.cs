using _02_array_sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace data_structure_test
{
    [TestClass]
    public class QuickSortingTest
    {
        [TestMethod]
        public void Test_Quick_Sort_When_Input_IsCorrect()
        {
            CommonMethod.RunTestsForSortAlgorithm(QuickSorting.Sort);
        }
    }
}
