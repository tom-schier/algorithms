using System;
namespace Peaks
{
    public class Peaks
    {
        public Peaks()
        {
        }

        private bool isPrimeNumber(int a)
        {

            for(var i = 2; i < a; i++)
            {
                if (a%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private int arrayHasPeak(int[] A, int? elemBefore, int? elemAfter)
        {
            if (A.Length < 3)
                return -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                {
                    if (elemBefore < A[i] && A[i + 1] < A[i])
                        return i;
                    else
                        continue;

                }
                if (i < A.Length - 1) {
                    if (A[i] > A[i - 1] && A[i + 1] < A[i])
                        return i;
                    else
                        continue;
                }
                if (i == A.Length-1)
                {
                    if (elemAfter < A[i] && A[i - 1] < A[i])
                        return i;
                    else
                        continue;
                }
            }
            return -1;
        }

        public int solution(int[] A)
        {
            //check of array length is prime number. If yes, the maximum possible number of blocks is 1
            if (A.Length == 0)
                return 0;

            if (isPrimeNumber(A.Length))
            {
                //this array cannot be divided because of its length
                var p = arrayHasPeak(A, null, null);
                if (arrayHasPeak(A, null, null) > -1)
                {
                    Console.WriteLine("Peak at " + p);
                    //but it does have a peak
                    return 1;
                }
                else
                    //and it does not have a peak
                    return 0;
            }

            var arrLength = 0;
            var arrCount = 0;
            var blockCount = 0;
            
            do
            {
                arrCount++;
                var canDivide = A.Length % arrCount == 0;
                if (!canDivide) continue;

                int[] testArray;
                arrLength = A.Length / arrCount;
                if (arrLength > 3)
                {
                    var arrayWithNoPeakFound = false;
                    for (int i = 0; i < arrCount; i++)
                    {
                        testArray = new int[arrLength];
                        int? elemBefore = null;
                        int? elemAfter = null;
                        if (i > 0)
                            elemBefore = A[i * arrLength - 1];
                        if (i < arrCount-1)
                            elemAfter = A[(i+1) * arrLength];
                        Console.Write("Test array " + 1 + " : ");

                        for (int j = 0; j < arrLength; j++)
                        {
                            var idx = i * arrLength + j;
                            testArray[j] = A[idx];
                            Console.Write(testArray[j] + ",");
                            
                        }
                        Console.WriteLine();

                        var p = arrayHasPeak(testArray, elemBefore, elemAfter);
                        Console.WriteLine("Peak at " + p);
                        if (p < 0)
                        {
                            arrayWithNoPeakFound = true;
                            break;
                        }
                            
                    }
                    if (!arrayWithNoPeakFound)
                    {
                        blockCount = arrCount;
                    }

                }
                else
                {
                    var arr = new int[arrLength];
                    for (int j = 0; j < arrLength; j++)
                    {
                        arr[j] = A[j];

                    }
                    var p = arrayHasPeak(arr, null, null);
                    if (p > 0)
                        blockCount = arrCount;
                    Console.WriteLine("Peak at " + p);
                }



            } while (arrLength > 3);

            return blockCount;

        }
    }
}
