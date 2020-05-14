using System;

namespace ProgrammingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to programming test!");

            #region String Generator
            //string result = StringGenerator.GenerateString(5, 3);

            //Console.WriteLine("Result is - " + result);
            #endregion

            #region Find Pair in Array whose sum is provided as input
            //Console.WriteLine(FindPairInArray.Find(new int[] { 1, 5, 6, 8, 10, 15 }, 20));
            #endregion

            #region Linked List: Length Count
            LinkedList llist = new LinkedList();
            llist.Push(1);
            llist.Push(3);
            llist.Push(1);
            llist.Push(2);
            llist.Push(1);

            Console.WriteLine($"Linked list count by iterative method: {llist.GetCountByInterative()}");

            Console.WriteLine($"Linked list count by iterative method: {llist.GetCountByRecursive()}");

            #endregion

            Console.ReadLine();
        }
    }
}
