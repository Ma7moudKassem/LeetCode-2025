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
        ListNode n1 = new(1);
        ListNode n2 = new(2);
        ListNode n3 = new(3);
        ListNode n4 = new(4);
        ListNode n5 = new(5);
        //ListNode n6 = new(4);
        //ListNode n7 = new(5);

        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = n5;
        //n5.next = n6;
        //n6.next = n7;

        return n1;
    }
}

