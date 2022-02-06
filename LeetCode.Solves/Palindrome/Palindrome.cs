using LeetCode.Solves.Base;

namespace LeetCode.Solves.Palindrome
{
    public class Palindrome : BaseSolution<int, bool>
    {
        public override bool Solve(int param)
        {
            var x = $"{param}";
            var y = x.Reverse();
            return x == y;
        }
    }
}
