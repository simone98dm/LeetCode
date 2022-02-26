using LeetCode.Solves.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solves.CompareVersionNumbers
{
    public class CompareVersionNumbers : BaseSolution<string, string, int>
    {
        public override int Solve(string version1, string version2)
        {
            var c1 = version1.Split(".");
            var c2 = version2.Split(".");
            int len = c1.Length;
            if (c2.Length > len)
            {
                len = c2.Length;
            }
            for (int i = 0; i < len; i++)
            {
                int v1 = 0;
                if (i < c1.Length)
                {
                    v1 = int.Parse(c1[i]);
                }
                var v2 = 0;
                if (i < c2.Length)
                {
                    v2 = int.Parse(c2[i]);
                }
                if (v1 < v2)
                {
                    return 1;
                }

                if (v1 > v2)
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
