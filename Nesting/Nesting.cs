using System;
namespace Nesting
{
    public class Nesting
    {
        public Nesting()
        {
        }

        public int solution(string st)
        {
            if (st == "" || st == null)
                return 1;
            if (st.Length < 2)
                return 0;
            if (st[0] != '(')
                return 0;
            if (st[st.Length - 1] != ')')
                return 0;

            var openCnt = 1;
            var closeCnt = 0;
            for(var idx = 1; idx < st.Length; idx++)
            {
                var thisChar = st[idx];

                if (thisChar == '(' || thisChar == ')')
                {
                    if (thisChar == '(') openCnt++;
                    if (thisChar == ')') closeCnt++;
                    if (closeCnt > openCnt)
                        return 0;
                }
            }
            var rr = openCnt == closeCnt;
            return openCnt == closeCnt ? 1 : 0;
        }
    }
}
