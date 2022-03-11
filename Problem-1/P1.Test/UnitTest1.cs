using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace P1.Test {
    public class Tests {
        [Test]
        public void Test1() {
            Solution sln = new Solution();
            Assert.IsTrue(new List<int> { 0, 1 }.SequenceEqual(sln.TwoSum(new int[] { 2, 7, 11, 15 }, 9)));
            Assert.IsTrue(new List<int> { 1, 2 }.SequenceEqual(sln.TwoSum(new int[] { 3, 2, 4 }, 6)));
            Assert.IsTrue(new List<int> { 0, 1 }.SequenceEqual(sln.TwoSum(new int[] { 3, 3 }, 6)));
        }
    }
}
