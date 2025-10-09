MyStack myStack = new MyStack();

myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);
int x = myStack.Top(); // return 2
int y = myStack.Pop(); // return 2
bool v = myStack.Empty(); // return False

public class MyStack
{
    private Queue<int> _queue;
    private Queue<int> _temp;

    public MyStack()
    {
        _queue = new Queue<int>();
        _temp = new Queue<int>();
    }

    public void Push(int x)
    {
        _temp.Enqueue(x);

        while (_queue.Count > 0)
            _temp.Enqueue(_queue.Dequeue());

        (_queue, _temp) = (_temp, _queue);
    }

    public int Pop()
    {
        return _queue.Dequeue();
    }

    public int Top()
    {
        return _queue.Peek();
    }

    public bool Empty()
    {
        return _queue.Count == 0;
    }
}