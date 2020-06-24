using System.Collections.Generic;

namespace Problem1
{
    public class Solution: ISolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            //O(n)
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    //O(1)
                    return new int[] { dict[complement], i };
                }
                //O(1)
                dict[nums[i]] = i;
            }
            return new int[] { };
        }

    }
}
