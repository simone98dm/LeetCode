using LeetCode.Solves.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solves.LengthLastWord
{
    public class LengthLastWord : BaseSolution<string, int>
    {
        public override int Solve(string s)
        {
            string t = s.Trim();
            if (!t.Contains(' '))
            {
                return t.Length;
            }
            var sl = t.Split(' ');
            return sl[sl.Length - 1].Length;
        }
    }
}
