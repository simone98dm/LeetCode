using LeetCode.Solves.Base;

namespace LeetCode.Solves.ValidParentheses
{
    public class ValidParentheses : BaseSolution<string, bool>
    {
        public override bool Solve(string s)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    list.Add(s[i]);
                }
                else
                {
                    if (list.Count == 0)
                    {
                        return false;
                    }
                    var top = list.Last();
                    if (s[i] == ')' && top == '(' ||
                        s[i] == ']' && top == '[' ||
                        s[i] == '}' && top == '{')
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (list.Count == 0)
            {
                return true;
            }

            return false;
        }

    }
}
