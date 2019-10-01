using System;

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

                var exercise = new Peaks();
                //var A = new int[] { 1,2,3,4,3,4,1,2,3,4,6,2};
                //var A = new int[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
                var A = new int[] { 1, 2, 3, 2, 5,6,7,8,9,1};
                var result = exercise.solution(A);

                Console.WriteLine("Solution returned " + result);

                Console.Write("Enter 'n' key to enter new value or any other key to close ....");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (c == 'n');
        }
    }
}
