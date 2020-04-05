using _02_array_sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace data_structure_test
{
    [TestClass]
    public class InsertionSortingTest
    {
        [TestMethod]
        public void InsertionSort_ValidInput_SortedInput()
        {
            CommonMethod.RunTestsForSortAlgorithm(InsertionSorting.Sort);
        }
    }
}
