using LeetCode.Solves.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solves.MaximumSubarray
{
    public class MaximumSubarray : BaseSolution<int[], int>
    {
        public override int Solve(int[] nums)
        {
            int maxSummed = int.MinValue;
            int maxSummedCurrent = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                maxSummedCurrent += nums[i];
                if (maxSummedCurrent > maxSummed)
                {
                    maxSummed = maxSummedCurrent;
                }

                if (maxSummedCurrent < 0)
                {
                    maxSummedCurrent = 0;
                }
            }
            return maxSummed;
        }
    }
}
