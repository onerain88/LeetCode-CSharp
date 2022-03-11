using System;
using System.Collections.Generic;

namespace P3 {
    public class Solution {
        public int LengthOfLongestSubstring(string s) {
            int max = 0;
            int left = 0;
            int right = 0;
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++) {
                if (set.Contains(s[i])) {
                    while (left <= i) {
                        set.Remove(s[left]);
                        if (s[left++] == s[i]) {
                            break;
                        }
                    }
                }

                set.Add(s[i]);
                right = i;

                max = Math.Max(max, (right - left + 1));
            }
            return max;
        }
    }
}
