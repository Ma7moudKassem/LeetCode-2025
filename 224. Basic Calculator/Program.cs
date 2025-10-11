
Console.WriteLine(Calculate("(1+(4+5+2)-3)+(6+8)"));


int Calculate(string s)
{
    Stack<int> stack = [];
    int res = 0;
    int sign = 1;

    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];

        if (char.IsDigit(c))
        {
            int num = 0;
            while (i < s.Length && char.IsDigit(s[i]))
            {
                num = num * 10 + s[i] - '0';
                i++;
            }

            res += num * sign;
            i--;
        }
        else if (c == '+') sign = 1;
        else if (c == '-') sign = -1;
        else if (c == '(')
        {
            stack.Push(res);
            stack.Push(sign);

            res = 0;
            sign = 1;
        }
        else if (c == ')')
            res = (stack.Pop() * res) + stack.Pop();
    }

    return res;
}