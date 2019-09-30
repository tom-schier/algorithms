﻿using System;

namespace Peaks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peaks.");

            var c = 'n';
            do
            {
                Console.WriteLine("Enter a string: ");
                var st = Console.ReadLine();
                Console.WriteLine("Entered " + st + " values");

                var exercise = new Peaks();
                var A = int[] = [1,2,3,4,3,4,1,2,3,4,6,2];
                var result = exercise.solution(st);

                Console.WriteLine("Solution returned " + result);

                Console.Write("Enter 'n' key to enter new value or any other key to close ....");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (c == 'n');
        }
    }
}