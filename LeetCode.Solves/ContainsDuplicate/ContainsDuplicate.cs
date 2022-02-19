using LeetCode.Solves.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solves.ContainsDuplicate
{
    public class ContainsDuplicate : BaseSolution<int[], bool>
    {
        public override bool Solve(int[] nums)
        {
            return nums.GroupBy(x => x).Any(x => x.Count() > 1);
        }
    }
}
