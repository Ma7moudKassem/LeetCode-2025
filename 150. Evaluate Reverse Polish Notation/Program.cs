string[] tokens = ["4", "13", "5", "/", "+"];

Console.WriteLine(EvalRPN(tokens));

int EvalRPN(string[] tokens)
{
    Stack<int> stack = new();

    foreach (string token in tokens)
    {
        if (int.TryParse(token, out int num))
        {
            stack.Push(num);
        }
        else
        {
            int x = stack.Pop();
            int y = stack.Pop();
            switch (token)
            {
                case "+":
                    {
                        int res = y + x;
                        stack.Push(res);
                        break;
                    }
                case "-":
                    {
                        int res = y - x;
                        stack.Push(res);
                        break;
                    }
                case "*":
                    {
                        int res = y * x;
                        stack.Push(res);
                        break;
                    }
                case "/":
                    {
                        int res = y / x;
                        stack.Push(res);
                        break;
                    }
            }
        }
    }

    return stack.Peek();
}