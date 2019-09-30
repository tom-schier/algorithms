using System;
using System.Collections.Generic;

/**************
 * Given two strings str1 and str2 each of length N, the task is to generate and print all possible strings of length N
 * such that the character at index i of the generated string is either str1[i] or str2[i]
 **********/

namespace GenerateString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GenerateString problem");
            var c = 'n';
            do
            {
                string st1, st2;
                var sameLength = false;
                do
                {
                    Console.WriteLine("Enter the first string");
                    st1 = Console.ReadLine();
                    Console.WriteLine("Enter the second string");
                    st2 = Console.ReadLine();
                    sameLength = st1.Length == st2.Length;
                } while (sameLength == false);

                Console.WriteLine("Data entry Ok.");
                Console.WriteLine();

                var totalCount = 0;
                HashSet<string> myStrings = new HashSet<string>();

                if (myStrings.Add(st1) == true)
                {
                    totalCount++;
                    Console.WriteLine(st1);
                }
                if (myStrings.Add(st2) == true)
                {
                    totalCount++;
                    Console.WriteLine(st2);
                }
                var theLength = st1.Length;

                if (theLength > 1)
                {
                    for (var i = 0; i < st1.Length; i++)
                    {
                        //generate the first string
                        var tailString1 = "";
                        var frontString1 = "";
                        if (theLength > 1 && i < theLength - 1)
                            tailString1 = st1.Substring(i + 1, theLength - i - 1).ToString();
                        if (i > 0 && theLength > 1)
                            frontString1 = st1.Substring(0, i).ToString();

                        string printSt1 = "";
                        string printSt2 = "";

                        printSt1 = frontString1 + st1[i] + tailString1;
                        if (myStrings.Add(printSt1) == true)
                        {
                            totalCount++;
                            Console.WriteLine(printSt1);
                        }

                        printSt2 = frontString1 + st2[i] + tailString1;
                        if (myStrings.Add(printSt2) == true)
                        {
                            totalCount++;
                            Console.WriteLine(printSt2);
                        }

                        //generate the first string
                        var tailString2 = "";
                        var frontString2 = "";
                        if (theLength > 1 && i < theLength - 1)
                            tailString2 = st2.Substring(i + 1, theLength - i - 1).ToString();
                        if (i > 0 && theLength > 1)
                            frontString2 = st2.Substring(0, i).ToString();

                        printSt1 = "";
                        printSt2 = "";

                        printSt1 = frontString2 + st1[i] + tailString2;
                        if (myStrings.Add(printSt1) == true)
                        {
                            totalCount++;
                            Console.WriteLine(printSt1);
                        }

                        printSt2 = frontString2 + st2[i] + tailString2;
                        if (myStrings.Add(printSt2) == true)
                        {
                            totalCount++;
                            Console.WriteLine(printSt2);
                        }

                    }
                }
                Console.WriteLine("Created " + myStrings.Count + " combinations");
                Console.Write("Enter 'n' key to enter new values or any other key to close ....");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (c == 'n');

        }
    }
}
