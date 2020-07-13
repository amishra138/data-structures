using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ProgrammingTest
{
    /// <summary>
    /// Questions from Magic Software second round
    /// </summary>
    public class ProgrammingQuestions
    {
        /// <summary>
        /// What will be the output of below program and why?
        /// It does not convert values to a different type, it asserts that values are already of the expected type and 
        /// throws an exception if they aren't.
        ///<see cref="https://stackoverflow.com/questions/12647068/invalid-cast-exception-on-int-to-double"/>
        /// </summary>
        public void ToDoubleCast()
        {
            int i = 10;
            object o = i;
            double d = (double)i;
            double d1 = (double)o; //This line will throw error ans from Higher to lower type cast is not possible
            Console.WriteLine(--d1);
        }

        static int Total = 0;

        /// <summary>
        /// What will be the output and why?
        /// </summary>
        public static void ThreadJoinCall()
        {
            Thread thread1 = new Thread(ProgrammingQuestions.AddOneHundred);
            Thread thread2 = new Thread(ProgrammingQuestions.AddOneHundred);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Total = " + Total);
            Console.ReadLine();
        }
        private static void AddOneHundred()
        {
            for (int i = 1; i <= 100; i++)
            {
                Total++;
            }
        }

        /// <summary>
        /// Write a program to print M = 1, A = 2, G = 1... from below string
        /// </summary>
        public static void CharCountInString()
        {
            string sample = "MAGIC SOFTWARE";

            var chars = sample.ToCharArray();

            var data = chars
                            .GroupBy(x => x)
                            .OrderBy(x => x.Key)
                            .ToDictionary(grp => grp.Key, grp => grp.Count());

            foreach (var item in data)
            {
                Console.WriteLine(item.Key.ToString(), item.Value);
            }
        }
    }

    public class Emp
    {
        public static int age = 40;
        public static int salary = 25000;
    }

    public class Record : Emp
    {
        new public static int salary = 50000;

        /// <summary>
        /// What will be the ouput of the following line
        /// </summary>
        /// <param name="args"></param>
        public static void CallMe()
        {
            Console.WriteLine(Emp.age + "  " + Emp.salary + "  " + salary);
        }
    }
}
