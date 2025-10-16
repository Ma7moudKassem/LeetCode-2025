var root = ListNode.BuildTestList();

var res = DeleteDuplicates(root);

Console.WriteLine();
ListNode DeleteDuplicates(ListNode head)
{
    Dictionary<int, int> map = [];
    while (head != null)
    {
        if (!map.ContainsKey(head.val))
            map.Add(head.val, 0);

        map[head.val]++;
        head = head.next;
    }

    ListNode dummyNode = new(0);
    ListNode current = dummyNode;

    foreach (var item in map)
    {
        if (item.Value > 1)
            continue;

        current.next = new(item.Key);
        current = current.next;
    }

    return dummyNode.next;
}
