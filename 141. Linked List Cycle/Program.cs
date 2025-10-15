bool HasCycle(ListNode head)
{
    HashSet<ListNode> visited = [];

    while (head != null)
    {
        if (visited.Contains(head))
            return true;

        visited.Add(head);
        head = head.next;
    }

    return false;
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