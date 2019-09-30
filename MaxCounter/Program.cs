using System;

namespace MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MaxCounter.");

            var c = 'n';
            do
            {
                var exercise = new MaxCounter();
                var A = new int[] { 3, 4, 4, 6, 1, 4, 4};
                var result = exercise.solution(5, A);


                foreach(var r in result)
                {
                    Console.Write(r);
                    Console.Write(",");
                }

                Console.WriteLine();
                Console.Write("Enter 'n' key to enter new value or any other key to close ....");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (c == 'n');
        }
    }
}
