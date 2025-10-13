Console.WriteLine(MyAtoi("2147483646"));

int MyAtoi(string s)
{
    string term = s.Trim();

    if (string.IsNullOrEmpty(term))
        return 0;

    long num = 0;
    int sign = 1;
    int start = 0;

    if (term[0] == '-' || term[0] == '+')
    {
        if (term[0] == '-') sign = -1;

        start = 1;
    }

    for (int i = start; i < term.Length; i++)
    {
        char c = term[i];

        if (char.IsDigit(c))
        {
            num = num * 10 + (c - '0');

            if (num > int.MaxValue)
            {
                return sign == 1
                    ? int.MaxValue
                    : int.MinValue;
            }
        }
        else
           break;
    }

    return (int)num * sign;
}
