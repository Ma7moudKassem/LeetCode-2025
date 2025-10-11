Console.WriteLine(Calculate("3+2*2"));

int Calculate(string s)
{
    int res = 0;
    char sign = '+';
    Stack<int> stack = [];

    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];
        if (char.IsDigit(c))
            res = res * 10 + (c - '0');

        if(!char.IsDigit(c) && c != ' ' || i < s.Length)
        {
            switch (sign)
            {
                case '+': stack.Push(res); break;
                case '-': stack.Push(-res); break;
                case '*': stack.Push(stack.Pop() * res); break;
                case '/': stack.Push(stack.Pop() / res); break;
            }

            sign = c;
            res = 0;
        }
    }

    return stack.Sum();
}