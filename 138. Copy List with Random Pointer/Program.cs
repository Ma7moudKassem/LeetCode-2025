
Node CopyRandomList(Node head)
{
    if (head is null)
        return null;

    Node current = head;

    Dictionary<Node, Node> map = [];

    while (current != null)
    {
        map[current] = new Node(current.val);
        current = current.next;
    }

    current = head;

    while (current != null)
    {
        map[current].next = current.next != null ? map[current.next] : null;
        map[current].random = current.random != null ? map[current.random] : null;
        current = current.next;
    }

    return map[head];
}

// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
