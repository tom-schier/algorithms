using System;
using System.Collections.Generic;

namespace MaxCounters
{

    public class MaxCounter
    {
        public MaxCounter()
        {
        }

        public int[] solution(int N, int[] A)
        {
            var operationList = new List<int>();
            operationList.AddRange(A);

            int[] resultList = new int[N];
            int maxValue = 0;

            foreach(var op in operationList)
            {
                var tmp = 0;
                if (op >= 1 && op <= N)
                {
                    resultList[op-1]++;
                    tmp = resultList[op-1];
                }
                    
                if (op > N)
                {
                    for(var i = 0; i < N; i++)
                    {
                        resultList[i] = maxValue;
                    }
                }
                if (tmp > maxValue)
                    maxValue = tmp;
            }
            return resultList;
        }
    }
}
