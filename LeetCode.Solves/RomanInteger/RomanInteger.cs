using LeetCode.Solves.Base;

namespace LeetCode.Solves.RomanInteger
{
    public class RomanInteger : BaseSolution<string, int>
    {
        public override int Solve(string param)
        {
            var map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            int number = 0;
            char[] chars = param.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                int nextIndex = i + 1;
                if (nextIndex < chars.Length)
                {
                    if (map[chars[i]] < map[chars[nextIndex]])
                    {
                        number += map[chars[i + 1]] - map[chars[i]];
                        i++;
                        continue;
                    }

                }
                number += map[chars[i]];
            }

            return number;
        }
    }
}
