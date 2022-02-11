using LeetCode.Solves.Base;

namespace LeetCode.Solves.TwoSum
{
    public class TwoSum : BaseSolution<int[], int, int[]>
    {
        public override int[] Solve(int[] param1, int param2)
        {
            int i = 0;
            int j = i + 1;
            while ((param1[i] + param1[j]) != param2)
            {
                if (j == (param1.Length - 1))
                {
                    i++;
                    j = i;
                }
                j++;
            }
            return new int[] { i, j };
        }
    }
}
