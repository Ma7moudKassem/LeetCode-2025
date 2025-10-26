using System.Text;

Console.WriteLine(HasSameDigits("3902"));
bool HasSameDigits(string s)
{
    while (s.Length > 2)
        s = CombineDigits(s);

    return s[0] == s[1];
}

string CombineDigits(string s)
{
    StringBuilder sp = new(s.Length - 1);
    for (int i = 0; i < s.Length - 1; i++)
    {
        int a = s[i] - '0',
            b = s[i + 1] - '0';

        int c = (a + b) % 10;

        sp.Append((char)(c + '0'));
    }

    return sp.ToString();
}