
//Console.WriteLine($"char: '(' -> {(int)'('} \nchar: ')' -> {(int)')'}");
//Console.WriteLine($"char: '[' -> {(int)'['} \nchar: ']' -> {(int)']'}");
//Console.WriteLine($"char: '{{' -> {(int)'{'} \nchar: '}}' -> {(int)'}'}");

Console.WriteLine(IsValid("(]"));

bool IsValid(string s)
{
    if (string.IsNullOrEmpty(s) || s.Length < 2)
        return false;

    Stack<char> stack = [];

    foreach (char c in s)
    {
        if (IsOpen(c))
        {
            stack.Push(c);
            continue;
        }
     
        if (stack.Count == 0 || !IsMatch(stack.Peek(), c))
            return false;

        stack.Pop();
    }

    return stack.Count == 0;
}

bool IsOpen(char c) =>
    c is '(' or '{' or '[';

bool IsMatch(char open, char close)
{
    return (open == '(' && close == ')') ||
           (open == '{' && close == '}') ||
           (open == '[' && close == ']');
}