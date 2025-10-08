MinStack minStack = new MinStack();
minStack.Push(2147483646);
minStack.Push(2147483646);
minStack.Push(2147483647);
Console.WriteLine(minStack.Top());
minStack.Pop();
Console.WriteLine(minStack.GetMin());
minStack.Pop();
Console.WriteLine(minStack.GetMin());
minStack.Pop();
minStack.Push(2147483647);
Console.WriteLine(minStack.Top());
Console.WriteLine(minStack.GetMin());
minStack.Push(-2147483648);
Console.WriteLine(minStack.Top());
Console.WriteLine(minStack.GetMin());
minStack.Pop();
Console.WriteLine(minStack.GetMin());

// return -2

public class MinStack
{
    private Stack<int> _data;
    private Stack<int> _min;
    public MinStack()
    {
        _data = [];
        _min = [];
    }


    public void Push(int val)
    {
        _data.Push(val);

        if (_min.Count == 0)
        {
            _min.Push(val);
            return;
        }

        if (_min.Peek() >= val)
            _min.Push(val);
    }

    public void Pop()
    {
        if (_data.Count == 0)
            return;

        int peek = _data.Pop();

        if (_min.Count == 0)
            return;

        if (peek == _min.Peek())
            _min.Pop();
    }

    public int Top() =>
        _data.Count != 0 ?
        _data.Peek() : 0;

    public int GetMin() =>
        _min.Count != 0 ? 
        _min.Peek() : 0;
}
