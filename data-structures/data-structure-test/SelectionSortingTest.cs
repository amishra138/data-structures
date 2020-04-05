using _02_array_sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace data_structure_test
{
    [TestClass]
    public class SelectionSortingTest
    {
        [TestMethod]
        public void SelectionSort_ValidInput_SortedOutPut()
        {
            CommonMethod.RunTestsForSortAlgorithm(SelectionSorting.Sort);
        }
    }
}
