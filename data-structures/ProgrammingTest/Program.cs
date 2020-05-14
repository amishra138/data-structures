using ProgrammingTest.List;
using System;
using System.Collections.Generic;

namespace ProgrammingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to programming test!");
            LineSeperator();

            //Generate string in pattern
            string result = StringGenerator.GenerateString(5, 3);
            Console.WriteLine("Result is - " + result);
            LineSeperator();

            //Find Pair in Array whose sum is provided as input
            Console.WriteLine(FindPairInArray.Find(new int[] { 1, 5, 6, 8, 10, 15 }, 20));
            LineSeperator();

            //Linked List: Length Count
            (new LinkedList()).RunProgram();
            LineSeperator();

            //Sort list of dates
            ListExtensions.RunProgram();
            LineSeperator();

            Console.ReadLine();
        }

        static void LineSeperator() => Console.WriteLine("-----------------------------------------------------------------------------------------------------");
    }
}
