using System;

namespace Problem1
{
    public class NaiveSolution : ISolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //O(n)
            for (int i = 0; i < nums.Length; i++)
            {
                //O(n)
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("No two sums solution");
        }
    }
}

