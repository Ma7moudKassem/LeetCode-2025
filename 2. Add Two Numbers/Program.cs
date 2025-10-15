
ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode dummyHead = new(0);
    ListNode current = dummyHead;

    int carry = 0;
    while (l1 != null || l2 != null || carry != 0)
    {
        int x = (l1 != null) ? l1.val : 0;
        int y = (l2 != null) ? l2.val : 0;

        int sum = x + y  + carry;

        carry = sum / 10;

        ListNode newNode = new ListNode(sum % 10);

        current.next = newNode;
        current = current.next;

        if (l1 != null) l1 = l1.next;
        if (l2 != null) l2 = l2.next;
    }

    return dummyHead.next;
}
    
class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}