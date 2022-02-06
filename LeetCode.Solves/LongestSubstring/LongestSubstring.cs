using LeetCode.Solves.Base;

namespace LeetCode.Solves.LongestSubstring
{
    public class LongestSubstring : BaseSolution<string, int>
    {
        public override int Solve(string s)
        {
            var l = 0;
            var c = 0;
            var letters = new Dictionary<char, bool>();
            for (int i = 0; i < s.Length; i++)
            {
                if (letters.ContainsKey(s[i]))
                {
                    if (c > l)
                    {
                        l = c;
                    }

                    c = 1;
                    letters = new Dictionary<char, bool>();
                }
                else
                {
                    c++;
                }
                letters.Add(s[i], true);
            }
            if (c > l)
            {
                l = c;
            }

            return l;
        }
    }
}
