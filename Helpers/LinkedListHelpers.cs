using System.Xml.Linq;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode BuildTestList()
    {
        ListNode n1 = new(7);
        ListNode n2 = new(13);
        ListNode n3 = new(11);
        ListNode n4 = new(10);
        ListNode n5 = new(1);

        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = n5;

        return n1;
    }
}

