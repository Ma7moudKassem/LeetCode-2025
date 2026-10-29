using System.Text;

Console.WriteLine(RepeatedStringMatch("aa", "a"));


int RepeatedStringMatch(string a, string b)
{
    int times = 0;
    StringBuilder s = new();

    while (s.Length < b.Length)
    {
        s.Append(a);
        times++;
    }

    if (s.ToString().Contains(b))
        return times;

    s.Append(a);
    times++;
    if (s.ToString().Contains(b))
        return times;

    return -1;
}