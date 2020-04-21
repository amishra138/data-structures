using System.Collections.Generic;

namespace _03_tree_structure
{
    /// <summary>
    /// A set is a collection that contains no duplicate element,and whose elements are in no particular order
    /// </summary>
    public class SetDataStructure<T>
    {
        public HashSet<T> Set1 { get; private set; }
        public HashSet<T> Set2 { get; private set; }

        public SetDataStructure(HashSet<T> set1, HashSet<T> set2)
        {
            Set1 = set1;
            Set2 = set2;
        }

        /// <summary>
        /// Return all elements from set 1 & set 2
        /// </summary>
        /// <returns></returns>
        public HashSet<T> Union()
        {
            var newSet = new HashSet<T>(Set1);
            newSet.UnionWith(Set2);
            return newSet;
        }

        /// <summary>
        /// Return only element which are common in both set
        /// </summary>
        /// <returns></returns>
        public HashSet<T> Intersection()
        {
            var newSet = new HashSet<T>(Set1);
            newSet.IntersectWith(Set2);
            return newSet;
        }
    }
}
