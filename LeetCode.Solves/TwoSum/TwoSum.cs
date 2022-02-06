using LeetCode.Solves.Base;

namespace LeetCode.Solves.TwoSum
{
    public class TwoSum : BaseSolution<int[], int, int[]>
    {
        public override int[] Solve(int[] param1, int param2)
        {
            for (var i = 0; i < param1.Length; i++)
            {
                for (var j = 0; j < param1.Length; j++)
                {
                    if (i != j && (param1[i] + param1[j]) == param2)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0];
        }
    }
}
