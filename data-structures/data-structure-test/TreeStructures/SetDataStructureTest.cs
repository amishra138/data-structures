using _03_tree_structure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace data_structure_test.TreeStructures
{
    [TestClass]
    public class SetDataStructureTest
    {
        [TestMethod]
        public void Test_HashSet_With_IntValues()
        {
            var set1 = new HashSet<int>() { 1, 2, 3, 5, 9 };
            var set2 = new HashSet<int>() { 2, 4, 6, 8 };

            var setObj = new SetDataStructure<int>(set1, set2);

            var unionOfSet = setObj.Union();
            var intersectOfSet = setObj.Intersection();

            Assert.AreEqual(8, unionOfSet.Count);
            Assert.AreEqual(1, intersectOfSet.Count);

        }
    }
}
