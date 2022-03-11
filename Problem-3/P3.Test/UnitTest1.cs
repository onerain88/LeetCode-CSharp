using NUnit.Framework;

namespace P3.Test {
    public class Tests {
        [Test]
        public void Test1() {
            Solution sln = new Solution();
            Assert.AreEqual(sln.LengthOfLongestSubstring("abcabcbb"), 3);
            Assert.AreEqual(sln.LengthOfLongestSubstring("bbbbb"), 1);
            Assert.AreEqual(sln.LengthOfLongestSubstring("pwwkew"), 3);
        }
    }
}
