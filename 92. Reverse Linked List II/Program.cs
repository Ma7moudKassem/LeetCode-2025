var root = ListNode.BuildTestList(); //7 - 13 - 11 - 10 - 1

var res = ReverseBetween(root, 2, 4); //10 - 11 - 13 - 7 - 1

Console.WriteLine(res);
ListNode ReverseBetween(ListNode head, int left, int right)
{
    List<int> values = [];
    while (head != null)
    {
        values.Add(head.val);

        head = head.next;
    }

    ListNode dummayNode = new(0);
    ListNode current = dummayNode;

    for (int i = 0; i < values.Count; i++)
    {
        if (i + 1 == left)
        {
            int j = right - 1;
            while (j > i)
            {
                int val = values[j];
                current.next = new ListNode(val);
                current = current.next;
                j--;
            }

            i = right - 1;
            current.next = new(values[left - 1]);
            current = current.next;
        }
        else
        {
            int val = values[i];
            current.next = new ListNode(val);
            current = current.next;
        }
    }

    return dummayNode.next;
}