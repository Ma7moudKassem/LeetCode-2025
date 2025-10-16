var root = ListNode.BuildTestList(); //1,2,3,4,5

var res = RotateRight(root, 2);

ListNode RotateRight(ListNode head, int k)
{
    if (head == null || head.next == null) 
        return head;

    int length = 1;

    ListNode tail = head;
    while (tail.next != null)
    {
        tail = tail.next;
        length++;
    }


    k %= length;

    tail.next = head;
    int stepsToNewHead = length - k;

    ListNode newTail = tail;
    while (stepsToNewHead-- > 0)
        newTail = newTail.next;

    ListNode newHead = newTail.next;
    newTail.next = null;

    return newHead;
}