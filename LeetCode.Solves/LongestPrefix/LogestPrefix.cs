using LeetCode.Solves.Base;

namespace LeetCode.Solves.LongestPrefix
{
    public class LogestPrefix : BaseSolution<string[], string>
    {
        public override string Solve(string[] param)
        {
            string s = string.Empty;
            string first = param[0];

            var all = param.Where(x => x != first);

            for (int i = 0; i < first.Length; i++)
            {
                s += first[i];
                if (!all.All(word => word.StartsWith(s)))
                {
                    return s.Remove(s.Length - 1);
                }
            }

            return s;
        }
    }
}
