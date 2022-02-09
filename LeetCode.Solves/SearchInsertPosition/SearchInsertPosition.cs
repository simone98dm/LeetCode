using LeetCode.Solves.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solves.SearchInsertPosition
{
    public class SearchInsertPosition : BaseSolution<int[], int, int>
    {
        public override int Solve(int[] param1, int param2)
        {
            for (int i = 0; i < param1.Length; i++)
            {
                if (param1[i] >= param2)
                {
                    return i;
                }
            }

            return param1.Length;
        }
    }
}
