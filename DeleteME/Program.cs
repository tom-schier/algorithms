using System;
using System.Collections.Generic;
using MaxXounters;

namespace DeleteME
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entered " + args.Length + " values");

            var exercise = new MaxCounter();
            var A = new int[] { 3, 4, 4, 6, 1, 4, 4 };
            var result = exercise.solution(5, A);

            foreach(var r in result)
            {
                Console.Write(r);
                Console.WriteLine(",");
            }

            Console.Write("Enter 'n' key to enter new value or any other key to close ....");
            var c = Console.ReadKey().KeyChar;
        }
    }
}
