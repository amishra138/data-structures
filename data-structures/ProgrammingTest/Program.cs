using ProgrammingTest.Array;
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

            //find non repeating elements from array
            new FindNonRepeatingElementsinArray().Get2NonRepeatingNos(new int[] { 1, 3, 6, 3, 10, 1,4 }, 1, 3);
            LineSeperator();

            //reverse sentence
            new StringManipulation().ReverseSentence("My name is Arvind Mishra");
            Console.ReadLine();
        }

        static void LineSeperator() => Console.WriteLine("-----------------------------------------------------------------------------------------------------");


    }
}
