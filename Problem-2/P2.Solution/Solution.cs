namespace P2 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode result = null;
            ListNode last = null;
            int carry = 0;
            while (l1 != null || l2 != null) {
                int x = l1 == null ? 0 : l1.val;
                int y = l2 == null ? 0 : l2.val;
                int sum = x + y + carry;
                ListNode current = new ListNode(sum % 10);
                if (last == null) {
                    result = last = current;
                } else {
                    last.next = current;
                    last = current;
                }
                carry = (int)(sum / 10);
                l1 = l1?.next;
                l2 = l2?.next;
            }
            if (carry > 0) {
                last.next = new ListNode(carry);
            }
            return result;
        }
    }
}
