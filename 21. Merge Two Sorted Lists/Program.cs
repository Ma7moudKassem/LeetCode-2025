ListNode root1 = new(1);

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode dummyNode = new(0);
    ListNode current = dummyNode;

    while (list1 != null && list2 != null)
    {
        if (list1.val > list2.val)
        {
            current.next = list1;
            list1 = list1.next;
        }
        else
        {
            current.next = list2;
            list2 = list2.next;
        }

        current = current.next;
    }

    if (list1 != null)
        current.next = list1;
    else current.next = list2;

    return dummyNode.next;
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