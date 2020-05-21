using ProgrammingTest.Array;
using ProgrammingTest.List;
using System;

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
            LineSeperator();

            //rotate array
            ArrayRotation.RotateArray();
            LineSeperator();

            //Dart Game Input Test
            var dartThrows = new string[] { "D20", "T20", "T20", "T20", "T10", "1", "D16", "17" };

            int dartScore = (new DartGame()).CalculateScore(dartThrows, out string message);


            Console.WriteLine($"Dart score : {dartScore}, {message}");

            Console.ReadLine();
        }

        static void LineSeperator() => Console.WriteLine("-----------------------------------------------------------------------------------------------------");


    }
}
