using LeetCode.Solves.Base;
using System.Diagnostics;

namespace LeetCode.Solves.MoveZeroes
{
    public class MoveZeroes : BaseSolution<int[]>
    {
        public override void Solve(int[] nums)
        {

            for (int x = 0, y = (x + 1); x < nums.Length; x++, y++)
            {
                if (nums[x] != 0)
                {
                    continue;
                }
                if (y < nums.Length)
                {
                    int nextValue = nums[y];
                    nums[y] = nums[x];
                    nums[x] = nextValue;
                }
            }
        }
    }
}
