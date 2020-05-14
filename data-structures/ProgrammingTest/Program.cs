using System;

namespace ProgrammingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to programming test!");

            string result = StringGenerator.GenerateString(5, 3);

            Console.WriteLine("Result is - " + result);

            Console.ReadLine();
        }
    }
}
