using System.Collections.Generic;

namespace P1 {
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) {
                int another = target - nums[i];
                if (dict.TryGetValue(another, out int index)) {
                    return new int[] { index, i };
                }
                dict.TryAdd(nums[i], i);
            }
            return new int[] { -1, -1 };
        }
    }
}
