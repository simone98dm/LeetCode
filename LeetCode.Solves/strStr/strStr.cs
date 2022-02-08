using LeetCode.Solves.Base;

namespace LeetCode.Solves.strStr
{
    public class strStr : BaseSolution<string, string, int>
    {
        public override int Solve(string param1, string param2)
        {
            if (string.IsNullOrEmpty(param2))
            {
                return 0;
            }

            if (param1.Length < param2.Length)
            {
                return -1;
            }

            char[] vs = param2.ToArray();
            for (int i = 0; i < param1.Length; i++)
            {
                if (param1[i] == vs[0] && (param1.Length - i >= param2.Length))
                {
                    if (param1.Substring(i, param2.Length) == param2)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
