using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace P2.Test {
    public static class ListNodeExt {
        public static List<int> ToList(this ListNode node) {
            List<int> list = null;
            while (node != null) {
                if (list == null) {
                    list = new List<int>();
                }
                list.Add(node.val);
                node = node.next;
            }

            return list;
        }
    }

    public class Tests {
        private ListNode CreateNode(IEnumerable<int> values) {
            ListNode node = null;
            ListNode current = null;
            foreach (int val in values) {
                if (current == null) {
                    node = current = new ListNode(val);
                } else {
                    current.next = new ListNode(val);
                    current = current.next;
                }
            }
            return node;
        }


        [Test]
        public void Test1() {
            Solution sln = new Solution();

            Assert.IsTrue(new int[] { 7, 0, 8 }.SequenceEqual(sln.AddTwoNumbers(
                CreateNode(new int[] { 2, 4, 3 }), CreateNode(new int[] { 5, 6, 4 })).ToList()));
            Assert.IsTrue(new int[] { 0 }.SequenceEqual(sln.AddTwoNumbers(
                CreateNode(new int[] { 0 }), CreateNode(new int[] { 0 })).ToList()));
            Assert.IsTrue(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 }.SequenceEqual(sln.AddTwoNumbers(
                CreateNode(new int[] { 9, 9, 9, 9, 9, 9, 9 }), CreateNode(new int[] { 9, 9, 9, 9 })).ToList()));
        }
    }
}
