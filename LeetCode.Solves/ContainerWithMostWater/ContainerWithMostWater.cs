using LeetCode.Solves.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solves.ChampagneTower
{
    public class ContainerWithMostWater : BaseSolution<int[], int>
    {
        public override int Solve(int[] height)
        {
            int maxArea = 0, i = 0, j = height.Length - 1;
            while (i < j)
            {
                int area;
                int len = j - i;
                if (height[i] > height[j])
                {
                    area = height[j] * len;
                    j--;
                }
                else
                {
                    area = height[i] * len;
                    i++;
                }

                if (area > maxArea)
                {
                    maxArea = area;
                }
            }
            return maxArea;
        }
    }
}
