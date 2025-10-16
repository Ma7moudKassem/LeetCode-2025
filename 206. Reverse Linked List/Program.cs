var root = ListNode.BuildTestList(); //7-13-11-10-1

var res = ReverseList(root);

ListNode ReverseList(ListNode head)
{
    List<int> values = [];
    while (head != null)
    {
        values.Add(head.val);

        head = head.next;
    }

    ListNode dummayNode = new(0);
    ListNode current = dummayNode;

    for(int i = values.Count - 1; i >= 0; i--)
    {
        int val = values[i];
        current.next = new ListNode(val);
        current = current.next;
    }

    return dummayNode.next;
}