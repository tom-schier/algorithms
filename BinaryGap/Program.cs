using System;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BinaryGap Gap!");
            var c = 'n';
            do
            {
                Console.WriteLine("Enter an integer value");
                var st = Console.ReadLine();
                int testValue;
                Int32.TryParse(st, out testValue);

                var binaryString = Convert.ToString(testValue, 2);
                Console.WriteLine("Binary string is " + binaryString);

                var gap = 0;
                var lastGap = 0;
                var stArray = binaryString.Split();
                var n = binaryString.IndexOf('0'); ;
                var subStr = binaryString;

                while (subStr.Length > 1)
                {
                    //find the next 1
                    n = subStr.IndexOf('0');
                    if (n < 0)
                        break;
                    //find the next 0
                    var idx = subStr.IndexOf('1', n + 1);
                    if (idx < 0)
                    {
                        gap = subStr.Length - n;
                        subStr = "";
                    }
                    else
                    {
                        gap = idx - n;
                        subStr = subStr.Substring(idx, subStr.Length - idx);
                    }
                    if (gap > lastGap)
                        lastGap = gap;
                }

                Console.WriteLine("Max binary gap is: " + lastGap);
                Console.Write("Enter 'n' key to enter new value or any other key to close ....");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (c == 'n');

        }
    }
}
